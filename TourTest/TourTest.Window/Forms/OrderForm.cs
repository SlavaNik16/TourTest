using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using TourTest.Context.DB;
using TourTest.Context.Models;
using TourTest.Context.Models.Enums;
using TourTest.Context.Models.WorkUser;
namespace TourTest.Window.Forms
{
    public partial class OrderForm : Form
    {
        private Dictionary<Tour, int> orders;
        private decimal sum = 0;
        private int discount = 0;
        public OrderForm(Dictionary<Tour, int> orders)
        {
            InitializeComponent();
            this.orders = orders;
            var user = WorkToUser.User;
            labelFIO.Text = $"{user.Surname} {user.Name} {user?.Patronymic}";

            foreach (var item in orders.Keys)
            {
                var orderView = new OrderView(item, orders[item]);
                orderView.ChangeCount += UpdateSum;
                orderView.Visible = true;
                orderView.Margin = new Padding(0, 0, 0, 50);
                orderView.Parent = flowLayoutPanel1;
                sum += item.Price * orderView.Count;
            }
            labelPrice.Text = $"{sum:C2}";

            using (var db = new TourContext())
            {
                comboBoxAddress.Items.AddRange(db.ReceivingPoints.ToArray());
                comboBoxAddress.SelectedIndex = 0;
            }

        }

        private void UpdateSum()
        {
            sum = 0;
            foreach (var item in flowLayoutPanel1.Controls)
            {
                if (item is OrderView orderView)
                {
                    sum += orderView.Tour.Price * orderView.Count;
                    if (orders.TryGetValue(orderView.Tour, out var count))
                    {
                        orders[orderView.Tour] = orderView.Count;
                    }
                }
            }
            labelPrice.Text = $"{sum:C2}";
        }

        private void buttonTakeOrder_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var order = new Order()
            {
                Price = sum,
                Code = rnd.Next(100, 1000),
                ReceivingPointId =((ReceivingPoint)comboBoxAddress.SelectedItem).Id,
            };
            if (!WorkToUser.CompareTo(RoleType.Guest))
            {
                order.UserId = WorkToUser.User.Id;
            }
            using (var db = new TourContext())
            {
                var ids = orders.Keys.Select(x => x.Id).ToList();
                var tours = db.Tours.Include(x => x.Country).Where(x => ids.Contains(x.Id)).ToList();
                order.Tours = tours;
                db.Orders.Add(order);
                db.SaveChanges();
                MessageBox.Show("Вы успешно оформили заказ!");
                this.Close();
            }

        }
    }
}