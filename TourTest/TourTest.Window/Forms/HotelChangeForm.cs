using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TourTest.Context.DB;
using TourTest.Context.Models;

namespace TourTest.Window.Forms
{
    public partial class HotelChangeForm : Form
    {
        private readonly Hotel hotel;
        public HotelChangeForm()
        {
            InitializeComponent();
            hotel = new Hotel();
            using (var db = new TourContext())
            {
                comboBoxCountry.DisplayMember = "Name";
                comboBoxCountry.Items.AddRange(db.Countries.ToArray());
                comboBoxCountry.SelectedIndex = 0;
            }
        }

        public HotelChangeForm(Hotel hotel) : this()
        {
            this.hotel = hotel;
            textBoxTitle.Text = hotel.Name;
            textBoxDescription.Text = hotel.Description;
            numericUpDownRank.Value = hotel.Rank;
            comboBoxCountry.SelectedItem = comboBoxCountry.Items.Cast<Country>()
                .FirstOrDefault(x => x.Code == hotel.CountryCode);
        }

        public Hotel Hotel => hotel;   
        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            hotel.Name = textBoxTitle.Text;
            ValidateHotel();
        }

        private void ValidateHotel()
        {
            buttonSave.Enabled =
                !string.IsNullOrWhiteSpace(hotel.Name);
        }

        private void numericUpDownRank_ValueChanged(object sender, EventArgs e)
        {
            hotel.Rank = (int)numericUpDownRank.Value;
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            hotel.CountryCode = ((Country)comboBoxCountry.SelectedItem).Code;
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            hotel.Description = textBoxDescription.Text;
        }
    }
}
