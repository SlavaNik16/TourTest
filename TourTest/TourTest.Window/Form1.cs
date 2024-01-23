using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourTest.Context.DB;

namespace TourTest.Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var db = new TourContext())
            {
                var tour = db.Tours.FirstOrDefault();
                if (tour != null)
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
