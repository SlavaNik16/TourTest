using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TourTest.Context.DB;
using TourTest.Context.Models;
using TourTest.Window.Forms;
using Type = TourTest.Context.Models.Type;

namespace TourTest.Window
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            comboBoxType.DisplayMember = nameof(Context.Models.Type.Name);
            comboBoxType.ValueMember = nameof(Context.Models.Type.Id);
            using (var db = new TourContext())
            {
                comboBoxType.DataSource =  db.Users.ToList();
            }
        }

        private void TourInfo_ImageChanged(object sender, (Context.Models.Tour, byte[]) e)
        {
            using (var db = new TourContext())
            {    
                db.Entry(e.Item1).State = EntityState.Modified;
                e.Item1.ImagePreview = e.Item2;
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
                comboBoxType.Items.Insert(0, new Context.Models.Type()
                {
                    Id = -1,
                    Name = "Все типы",
                });

                comboBoxType.SelectedIndex = 0;

                var tours = db.Tours.Include(nameof(Tour.Types)).ToList();
                foreach (var tour in tours)
                {

                    var tourInfo = new TourInfo(tour);
                    tourInfo.Parent = flowLayoutPanel;
                    tourInfo.ImageChanged += TourInfo_ImageChanged;
                }
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            if (comboBoxType.SelectedItem == null) return;
            var selectedTypeId = ((Type)comboBoxType.SelectedItem).Id;
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
                    tourInfo.Visible = visible;
                }
            }
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
                    tourInfoForm.Tour.Types = db.Types.Where(x => tourInfoForm.GetTypeIdsChecked().Contains(x.Id)).ToList();
                    db.Tours.Add(tourInfoForm.Tour);
                    db.SaveChanges();
                }
            }
        }
    }

}
