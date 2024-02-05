using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using TourTest.Context.DB;
using TourTest.Context.Models;
using TourTest.Context.Models.Enums;
using TourTest.Context.Models.WorkUser;
using TourTest.Window.Forms;
using Type = TourTest.Context.Models.Type;

namespace TourTest.Window
{
    public partial class TourForm : Form
    {
        private int allToursSum = 0;
        public static Dictionary<Tour,int> orders;
        public TourForm()
        {
            InitializeComponent();
            orders = new Dictionary<Tour,int>();
            comboBoxType.DisplayMember = nameof(Type.Name);
            comboBoxType.ValueMember = nameof(Type.Id);
            butAdd.Enabled = !WorkToUser.CompareTo(RoleType.Guest)
              && !WorkToUser.CompareTo(RoleType.Client);

        }

        private void TourInfo_ImageChanged(object sender, (Tour, byte[]) e)
        {
            using (var db = new TourContext())
            {    
                e.Item1.ImagePreview = e.Item2;
                db.Entry(e.Item1).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var db = new TourContext())
            {
                var query = db.Types.OrderBy(x => x.Name);

                comboBoxType.Items.Clear();
                comboBoxType.Items.AddRange(query.ToArray());
                comboBoxType.Items.Insert(0, new Type()
                {
                    Id = -1,
                    Name = "Все типы",
                });

                comboBoxType.SelectedIndex = 0;

                var tours = db.Tours.AsNoTracking().Include(x=>x.Types).ToList();
                allToursSum = 0;
                foreach (var tour in tours)
                {

                    var tourInfo = new TourInfo(tour);
                    tourInfo.Parent = flowLayoutPanel;
                    tourInfo.ImageChanged += TourInfo_ImageChanged;
                    tourInfo.CountOrdersChanged += TourInfo_CountOrdersChanged;
                    tourInfo.onAddToOrder += TourInfo_onAddToOrder;
                    tourInfo.onAddTour += TourInfo_onAddTour;

                    allToursSum += (int)(tour.Price * tour.TicketCount);
                }
                labelAllTourSum.Text = $"{allToursSum:C2}";
            }
        }

        private void TourInfo_onAddTour(int money)
        {
            allToursSum += money;
            labelAllTourSum.Text = $"{allToursSum:C2}";

        }

        private void TourInfo_onAddToOrder(Tour tour)
        {
            if (orders.TryGetValue(tour, out var count))
            {
                orders[tour] = ++count;
            }
            else
            {
                orders.Add(tour, 1);
            }
           
        }

        private void TourInfo_CountOrdersChanged(object sender, EventArgs e)
        {
            labelCountOrders.Text = orders.Count.ToString();
            butOrder.Visible = orders.Count != 0;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            if (comboBoxType.SelectedItem == null) return;
            var selectedTypeId = ((Type)comboBoxType.SelectedItem).Id;
            allToursSum = 0;
            foreach (var item in flowLayoutPanel.Controls)
            {
                var visible = true;
                if (item is TourInfo tourInfo)
                {
                    if (selectedTypeId != -1 &&
                        !tourInfo.Tour.Types.Any(x => x.Id == selectedTypeId))
                    {
                        visible = false;
                    }

                    if (checkBoxIsActual.Checked && !tourInfo.Tour.IsActual)
                    {
                        visible = false;
                    }

                    if (!(string.IsNullOrEmpty(textBoxSearch.Text) ||
                        tourInfo.Tour.Name.Contains(textBoxSearch.Text)))
                    {
                        visible = false;
                    }
                    if (visible)
                    {
                        allToursSum += (int)(tourInfo.Tour.Price * tourInfo.Tour.TicketCount);
                    }
                    tourInfo.Visible = visible;
                }
            }
            labelAllTourSum.Text = $"{allToursSum:C2}";
        }

        private void checkBoxIsActual_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var tourInfoForm = new TourInfoForm();
            if (tourInfoForm.ShowDialog() == DialogResult.OK)
            {
                using (var db = new TourContext())
                {
                    var ids = tourInfoForm.GetTypeIdsChecked();
                    tourInfoForm.Tour.Types = db.Types.Where(x => ids.Contains(x.Id)).ToList();
                    db.Tours.Add(tourInfoForm.Tour);
                    db.SaveChanges();

                    var tourInfo = new TourInfo(tourInfoForm.Tour);
                    tourInfo.Parent = flowLayoutPanel;
                    tourInfo.ImageChanged += TourInfo_ImageChanged;
                    tourInfo.CountOrdersChanged += TourInfo_CountOrdersChanged;
                    tourInfo.onAddToOrder += TourInfo_onAddToOrder;
                    tourInfo.onAddTour += TourInfo_onAddTour;

                    allToursSum += (int)(tourInfo.Tour.Price * tourInfo.Tour.TicketCount);
                    labelAllTourSum.Text = $"{allToursSum:C2}";
                }
            }
        }

        private void butOrder_Click(object sender, EventArgs e)
        {

            var orderForm = new OrderForm(orders);
            orderForm.ShowDialog();
        }
    }

}
