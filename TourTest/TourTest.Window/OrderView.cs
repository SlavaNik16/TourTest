using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TourTest.Context.Models;

namespace TourTest.Window
{
    public partial class OrderView : UserControl
    {
        public Tour Tour;
        public int Count;
        public Action ChangeCount;
        public OrderView(Tour tour, int count)
        {
            InitializeComponent();
            this.Tour = tour;
            Count = count;
            labelName.Text = Tour.Name;
            labelDescription.Text = string.IsNullOrWhiteSpace(Tour.Description) ? 
                "Описание отсутствует" : Tour.Description;
            labelCountry.Text = Tour.CountryCode.ToString();
            labelPrice.Text = $"Цена {Tour.Price:C2}";
            labelTicketCount.Text = $"Кол-во билетов: {Tour.TicketCount}";
            numericUpDownCount.Value = count;
            listBox1.DisplayMember = "Name";
            listBox1.Items.AddRange(Tour.Types.ToArray());
            if(Tour.ImagePreview != null)
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(Tour.ImagePreview));
            }

        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            Count = (int)numericUpDownCount.Value;
            ChangeCount?.Invoke();
        }
    }
}
