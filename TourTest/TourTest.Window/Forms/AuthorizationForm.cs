using System;
using System.Linq;
using System.Windows.Forms;
using TourTest.Context.DB;
using TourTest.Context.Models.WorkUser;
namespace TourTest.Window.Forms
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void buttonEntrance_Click(object sender, EventArgs e)
        {
            using (var db = new TourContext())
            {
                var user = db.Users.FirstOrDefault(x=>x.Login == textBoxLogin.Text &&
                                                    x.Password == textBoxPassword.Text);
                if (user == null)
                {
                    MessageBox.Show("Неправильное имя пользователя или пароль!", "Ошибка!",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                WorkToUser.User = user;
                var startForm = new StartForm();
                this.Hide();
                startForm.ShowDialog();
                this.Show();
            }
        }

        private void buttonEntranceGuest_Click(object sender, EventArgs e)
        {
            var startForm = new StartForm();
            this.Hide();
            startForm.ShowDialog();
            this.Show();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            buttonEntrance.Enabled = !string.IsNullOrWhiteSpace(textBoxLogin.Text)
               && !string.IsNullOrWhiteSpace(textBoxPassword.Text);
        }
    }
}
