using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TourTest.Context.DB;

namespace TourTest.Window
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            using (var db = new TourContext())
            {
                var tour = db.Tours.FirstOrDefault();
                if (tour != null && tour?.ImagePreview != null)
                {
                    pictureBox1.Image = Image.FromStream(new MemoryStream(tour.ImagePreview));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var db = new TourContext())
                {
                    var tour = db.Tours.FirstOrDefault();
                    if (tour == null) return;
                    var image = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                    tour.ImagePreview = image;
                    db.SaveChanges();
                    pictureBox1.Image = Image.FromStream(new MemoryStream(image));
                }
            }
        }
    }

}
