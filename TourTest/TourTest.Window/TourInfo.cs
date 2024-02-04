using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TourTest.Context.DB;
using TourTest.Context.Models;
using TourTest.Window.Forms;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Collections.Generic;

namespace TourTest.Window
{
    public partial class TourInfo : UserControl
    {
        private readonly Tour tour;
        private EventHandler<(Tour, byte[])> onImageChanged;
        private EventHandler onCountOrdersChanged;
        public event Action<Tour> onAddToOrder;
        public TourInfo(Tour tour)
        {
            InitializeComponent();
            this.tour = tour;
            InitTour(tour);

        }

        public Tour Tour => tour;
        private void InitTour(Tour tour)
        {
            labelName.Text = tour.Name;
            labelPrice.Text = $"{tour.Price:C2}";
            labelIsActual.Text = tour.IsActual ? "Актуален" : "Не актуален";
            labelIsActual.ForeColor = tour.IsActual ? Color.Green : Color.Red;
            labelTicketCount.Text = tour.TicketCount.ToString();
            if (tour.ImagePreview != null)
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(tour.ImagePreview));
            }
        }

        public event EventHandler<(Tour, byte[])> ImageChanged
        {
            add
            {
                onImageChanged += value;
            }
            remove
            {
                onImageChanged -= value;
            }
        }

        public event EventHandler CountOrdersChanged
        {
            add
            {
                onCountOrdersChanged += value;
            }
            remove
            {
                onCountOrdersChanged -= value;
            }
        }

        private void butEditPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var image = File.ReadAllBytes(openFileDialog1.FileName);
            onImageChanged?.Invoke(this, (tour, image));
            pictureBox1.Image = Image.FromStream(new MemoryStream(image));
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            var tourInfoForm = new TourInfoForm(tour);
            var result = tourInfoForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var ids = tourInfoForm.GetTypeIdsChecked();
                using (var db = new TourContext())
                {
                    var types = db.Types.Where(x => ids.Contains(x.Id)).ToList();
                    var tourInfo = db.Tours.Include(y=>y.Types).FirstOrDefault(x => x.Id ==  tour.Id);
                    tourInfoForm.Tour.Types = types;
                    tourInfo = tourInfoForm.Tour;
                    var intit = db.SaveChanges();
                    Console.WriteLine(intit);
                    InitTour(tourInfo);
                }
            }
            else if(result == DialogResult.Yes)
            {
                if (MessageBox.Show($"Вы уверены, что хотите удалить Тур:\n\tНазвание: {Tour.Name}\n\t" +
                    $"Цена: {Tour.Price}", "Предупреждение!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    using (var db = new TourContext())
                    {
                        var tourInfo = db.Tours.FirstOrDefault(x => x.Id == Tour.Id);
                        db.Tours.Remove(tourInfo);
                        db.SaveChanges();
                        this.Hide();
                    }
                }

            }
        }

        private void addToOrder_Click(object sender, EventArgs e)
        {
            if (tour.IsActual)
            {
                onAddToOrder?.Invoke(tour);
                onCountOrdersChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
