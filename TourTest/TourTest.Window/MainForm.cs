using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TourTest.Context.DB;

namespace TourTest.Window
{
    public partial class Form : System.Windows.Forms.Form
    {
        public List<TourInfo> toursInfo;
        public Form()
        {
            InitializeComponent();
            toursInfo = new List<TourInfo>();
            InitTours();
        }

        private void InitTours()
        {
            toursInfo.Clear();
            using (var db = new TourContext())
            {
                var tours = db.Tours.ToList();
                foreach (var tour in tours)
                {
                    var index = toursInfo.Count();
                    var tourInfo = new TourInfo();
                    tourInfo.Tag = tour.Id;
                    tourInfo.labelName.Text = tour.Name;
                    tourInfo.labelPrice.Text = $"{tour.Price:C2}";
                    tourInfo.labelIsActual.Text = tour.IsActual ? "Актуален" : "Не актуален";
                    tourInfo.labelIsActual.ForeColor = tour.IsActual ? Color.Green : Color.Red;
                    tourInfo.labelTicketCount.Text = tour.TicketCount.ToString();
                    if (tour.ImagePreview != null)
                    {
                        tourInfo.pictureBox1.Image = Image.FromStream(new MemoryStream(tour.ImagePreview));
                    }

                    tourInfo.butEdit.Tag = index;
                    tourInfo.butEditPhoto.Tag = index;
                    tourInfo.butEdit.Click += ButEdit_Click;
                    tourInfo.butEditPhoto.Click += ButEditPhoto_Click;
                    tourInfo.Parent = flowLayoutPanel;
                    toursInfo.Add(tourInfo);
                }
            }
        }

        private void ButEdit_Click(object sender, EventArgs e)
        {
            if(!(sender is Button but))
            {
                return;
            }
            Console.WriteLine($"Это была нажата кнопка с id = ");
            
        }

        private void ButEditPhoto_Click(object sender, EventArgs e)
        {
            if (!(sender is Button but))
            {
                return;
            }
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            using (var db = new TourContext())
            {
                if (!(but.Tag is TourInfo tourInfo))
                {
                    return;
                }
                var tour = db.Tours.FirstOrDefault(x => x.Id.ToString() == tourInfo.Tag.ToString());
                var image = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                tour.ImagePreview = image;
                db.SaveChanges();
                tourInfo.pictureBox1.Image = Image.FromStream(new MemoryStream(image));
            }
            
        }
    }

}
