using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourTest.Context.Models.Enums;
using TourTest.Context.Models.WorkUser;

namespace TourTest.Window.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            var user = WorkToUser.User;
            toolStripFIO.Text = $"{user.Surname} {user.Name} {user?.Patronymic}";
            toolStripRole.Text = $"{user.Role}";

            TourToolMenu.Enabled = !(WorkToUser.CompareTo(RoleType.Manager));
        }


        private void TourToolMenu_Click(object sender, EventArgs e)
        {

            var mainForm = new TourForm();
            this.Hide();
            mainForm.ShowDialog();
            this.Show();
        }

        private void HotelToolMenu_Click(object sender, EventArgs e)
        {
            var hotelForm = new HotelForm();
            this.Hide();
            hotelForm.ShowDialog();
            this.Show();
        }
    }
}
