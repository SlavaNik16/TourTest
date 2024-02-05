using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourTest.Context.DB;
using System.Data.Entity;
using TourTest.Context.Models;
using TourTest.Context.Models.WorkUser;
using TourTest.Context.Models.Enums;

namespace TourTest.Window.Forms
{
    public partial class HotelForm : Form
    {
        private int sizePage = 10;
        private int oldCurrent = -1;
        private BindingSource bindingSource;
        
        public HotelForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            bindingSource.CurrentItemChanged += BindingSource_CurrentItemChanged;
            dataGridView1.AutoGenerateColumns = false;
            Print();
            butAdd.Enabled =
            butEdit.Enabled =
            butDelete.Enabled =
                WorkToUser.CompareTo(RoleType.Admin);
                                    
        }

        private void BindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            Print();
        }

        private void Print()
        {
            using (var db = new TourContext())
            {
                var count = db.Hotels.Count();
                var pageLength = (int)Math.Ceiling((float)count / sizePage);

                if(oldCurrent != pageLength)
                {
                    oldCurrent = pageLength;
                    var current = bindingSource.Position;

                    if(current > pageLength)
                    {
                        current = pageLength;
                    }
                    bindingSource.DataSource = Enumerable.Range(1, pageLength);
                    if(current != -1)
                    {
                        bindingSource.Position = current;
                    }
                    bindingNavigator.BindingSource = bindingSource;
                }

                dataGridView1.DataSource = db.Hotels.Include(y => y.Country)
                    .OrderBy(x=>x.Name)
                    .Skip(bindingSource.Position * sizePage)
                    .Take(sizePage)
                    .ToList();
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            var hotel = (Hotel)dataGridView1.SelectedRows[0].DataBoundItem;

            if (hotel == null)
            {
                return;
            }
            using (var db = new TourContext())
            {
                var hotelDB = db.Hotels.Include(x => x.Tours).FirstOrDefault(x => x.Id == hotel.Id);
                if(hotelDB.Tours.Count(x=>x.IsActual) != 0)
                {
                    MessageBox.Show("Этот отель подходит к актуальным турам!!");
                    return;
                }

                if (MessageBox.Show($"Удалить ли отель {hotelDB.Name}?", "Подтвердите!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    db.Hotels.Remove(hotelDB);
                    db.SaveChanges();
                    Print();
                }
            }

        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            var hotelDataGrid = (Hotel)dataGridView1.SelectedRows[0].DataBoundItem;
            if(hotelDataGrid == null){
                return;
            }
            using (var db = new TourContext())
            {
                var hotelDB = db.Hotels.FirstOrDefault(x => x.Id == hotelDataGrid.Id);
                var hotelChange = new HotelChangeForm(hotelDB);
                if (hotelChange.ShowDialog() == DialogResult.OK)
                {
                        db.SaveChanges();
                        Print();
                }
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var hotelChange = new HotelChangeForm();
            if(hotelChange.ShowDialog() == DialogResult.OK)
            {
                using (var db = new TourContext())
                {
                    db.Hotels.Add(hotelChange.Hotel);
                    db.SaveChanges();
                    Print();
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Country")
            {
                var country = (Country)e.Value;
                e.Value = country.Name;
            }
        }
    }
}
