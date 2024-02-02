using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourTest.Window.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void бДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainForm = new TourForm();
            this.Hide();
            mainForm.ShowDialog();
            this.Show();
        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var hotelForm = new HotelForm();
            this.Hide();
            hotelForm.ShowDialog();
            this.Show();
        }
    }
}
