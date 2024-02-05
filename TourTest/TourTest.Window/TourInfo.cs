using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TourTest.Context.DB;
using TourTest.Context.Models;
using TourTest.Window.Forms;
using TourTest.Context.Models.WorkUser;
using TourTest.Context.Models.Enums;

namespace TourTest.Window
{
    public partial class TourInfo : UserControl
    {
        private readonly Tour tour;
        private EventHandler<(Tour, byte[])> onImageChanged;
        private EventHandler onCountOrdersChanged;
        public event Action<Tour> onAddToOrder;
        public event Action<int> onAddTour;
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
            butEdit.Enabled = butEditPhoto.Enabled = !WorkToUser.CompareTo(RoleType.Guest)
               && !WorkToUser.CompareTo(RoleType.Client);
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
            using (var db = new TourContext())
            {
                var tourDB = db.Tours.FirstOrDefault(x => x.Id == tour.Id);
                var tourInfoForm = new TourInfoForm(tourDB);
                var result = tourInfoForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var ids = tourInfoForm.GetTypeIdsChecked();
                    tourDB.Types.Clear();
                    tourDB.Types = db.Types.Where(x => ids.Contains(x.Id)).ToList();
                    db.SaveChanges();
                    InitTour(tourDB);
                    onAddTour?.Invoke((int)tourDB.Price * tourDB.TicketCount);
                }
                else if (result == DialogResult.Yes)
                {
                    if (MessageBox.Show($"Вы уверены, что хотите удалить Тур:\n\tНазвание: {tourDB.Name}\n\t" +
                        $"Цена: {tourDB.Price}", "Предупреждение!",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                       
                        db.Tours.Remove(tourDB);
                        db.SaveChanges();
                        this.Hide();
                        onAddTour?.Invoke(-((int)tourDB.Price * tourDB.TicketCount));
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
