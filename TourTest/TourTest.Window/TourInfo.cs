using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TourTest.Context.Models;

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
        public Tour Tour => tour;
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

        }
    }
}
