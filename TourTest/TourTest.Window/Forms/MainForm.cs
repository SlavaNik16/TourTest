using System;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TourTest.Context.DB;
using static System.Net.Mime.MediaTypeNames;

namespace TourTest.Window
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            using (var db = new TourContext())
            {
                var tours = db.Tours.ToList();
                foreach (var tour in tours)
                {
                    var tourInfo = new TourInfo(tour);
                    tourInfo.Parent = flowLayoutPanel;
                    tourInfo.ImageChanged += TourInfo_ImageChanged;
                }

                //}
                //string path = Directory.GetCurrentDirectory();
                //foreach (string fileName in Directory.GetFiles(Path.Combine(path, "materials")))
                //{
                //    var picture = new PictureBox();
                //    var fileByte = File.ReadAllBytes(fileName);
                //    picture.Image = System.Drawing.Image.FromStream(new MemoryStream(fileByte));
                //    picture.Size = new Size(200,150);
                //    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                //    picture.Parent = flowLayoutPanel;
                //}

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
        
    }

}
