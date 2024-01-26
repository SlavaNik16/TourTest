using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourTest.Context.DB;
using TourTest.Context.Models;

namespace TourTest.Window.Forms
{
    public partial class TourInfoForm : Form
    {
        private readonly Tour tour;
        private List<Country> countries;
        public TourInfoForm()
        {
            InitializeComponent();
            Text = "Добавление тура";
            butAdd.Text = "Добавить";
            /*CultureInfo cultureInfo = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            */
            butDelete.Visible= false;
            countries = new List<Country>();
            tour = new Tour();
            using (var db =new TourContext())
            {
                countries = db.Countries.ToList();
                comboBoxCountry.Items.Clear();
                comboBoxCountry.DataSource = countries.Select(x=>x.Name).ToList();
                comboBoxCountry.SelectedIndex = 0;
            }
        }
        public TourInfoForm(Tour tour) : this()
        {
            Text = "Изменения тура";
            butAdd.Text = "Изменить";
            this.tour = tour;
            butDelete.Visible = true;
            textBoxName.Text = tour.Name;
            textBoxPrice.Text = tour.Price.ToString();
            checkBoxIsActual.Checked = tour.IsActual;
            numericUpDownTicket.Value = tour.TicketCount;
            using (var db = new TourContext())
            {
                comboBoxCountry.SelectedItem = db.Countries.FirstOrDefault(x => x.Code == tour.CountryCode).Name;
            }
        }

        public Tour Tour => tour;

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            tour.Name = textBoxName.Text;
            ValidateTour();
        }

        private void ValidateTour()
        {
            butAdd.Enabled =
                !string.IsNullOrWhiteSpace(tour.Name) &&
                 decimal.TryParse(textBoxPrice.Text.ToString(), out decimal price);
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if(decimal.TryParse(textBoxPrice.Text.Trim(), out decimal price) && price > 0)
            {
                tour.Price = price;
            }
            ValidateTour();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void checkBoxIsActual_CheckedChanged(object sender, EventArgs e)
        {
            tour.IsActual = checkBoxIsActual.Checked;
        }

        private void numericUpDownTicket_ValueChanged(object sender, EventArgs e)
        {
            tour.TicketCount = (int)numericUpDownTicket.Value;
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            tour.CountryCode = countries[comboBoxCountry.SelectedIndex].Code;
        }
    }
}
