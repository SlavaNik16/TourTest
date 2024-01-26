using System;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TourTest.Context.DB;
using TourTest.Context.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TourTest.Window
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
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


        private const string TypeAll = "Все типы";
        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var db = new TourContext())
            {
                comboBoxType.Items.Clear();
                comboBoxType.Items.Add(TypeAll);
                db.Types.Select(x=>x.Name).ToList().ForEach(x=>comboBoxType.Items.Add(x));
                comboBoxType.SelectedIndex = 0;

                var tours = db.Tours.Include(nameof(Tour.Types)).ToList();
                foreach (var tour in tours)
                {

                    var tourInfo = new TourInfo(tour);
                    tourInfo.Parent = flowLayoutPanel;
                    tourInfo.ImageChanged += TourInfo_ImageChanged;
                }

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

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            using (var db = new TourContext())
            {
                foreach (var item in flowLayoutPanel.Controls)
                {
                    if (item is TourInfo tourInfo)
                    {
                        if (comboBoxType.SelectedItem.ToString() == TypeAll)
                        {
                            tourInfo.Visible =true;
                            if(checkBoxIsActual.Checked)
                            {
                                tourInfo.Visible = tourInfo.Tour.IsActual;
                            }
                            continue;
                        }
                        var truth = tourInfo.Tour.Types.Any(x => x.Name == comboBoxType.SelectedItem.ToString());

                        if (checkBoxIsActual.Checked && truth)
                        {
                            tourInfo.Visible = tourInfo.Tour.IsActual;
                            continue;
                        }
                        tourInfo.Visible = truth;
                    }
                }

            }
        }

        private void checkBoxIsActual_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            using (var db = new TourContext())
            {
                foreach (var item in flowLayoutPanel.Controls)
                {
                    if (item is TourInfo tourInfo)
                    {
                        if (textBoxSearch.Text.Trim() == string.Empty)
                        {
                            tourInfo.BackColor = Color.White;
                            continue;
                        }
                        tourInfo.BackColor = tourInfo.Tour.Name.Contains(textBoxSearch.Text.Trim()) ? Color.Gray : Color.White;
                    }
                }
            }
        }
    }

}
