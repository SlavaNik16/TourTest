using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TourTest.Context.DB;
using TourTest.Context.Models;
using TourTest.Window.Forms;

namespace TourTest.Window
{
    public partial class TourInfo : UserControl
    {
        private readonly Tour tour;
        private EventHandler<(Tour, byte[])> onImageChanged;
       
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
            var tourInfoForm = new TourInfoForm(Tour);
            var result = tourInfoForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (var db = new TourContext())
                {
                    var tour = db.Tours.Include(nameof(Tour.Types)).FirstOrDefault(x => x.Id == Tour.Id);
                    if (tour == null) { return; }
                    tour = tourInfoForm.Tour;
                    db.SaveChanges();
                    InitTour(tour);
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
                        var tour = db.Tours.Include(nameof(Tour.Types)).FirstOrDefault(x => x.Id == Tour.Id);
                        if (tour == null) { return; }
                        db.Tours.Remove(tour);
                        db.SaveChanges();
                        this.Hide();
                    }
                }

            }
        }
    }
}
