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

namespace TourTest.Window.Forms
{
    public partial class HotelForm : Form
    {
        private int sizePage = 10;
        private int current = 1;
        private int oldCurrent = -1;
        private BindingSource bindingSource;
        
        public HotelForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            using (var db = new TourContext())
            {
                dataGridView1.DataSource = db.Hotels.Include(y => y.Country).Select(x =>new
                {
                    Name = x.Name,
                    Rank = x.Rank,
                    Country = x.Country.Name,
                    Description = x.Description,
                }).ToList();
            }
            Print();
        }
        private void Print()
        {
            using (var db = new TourContext())
            {
                var count = db.Hotels.Count();
                var pageLength = (int)Math.Ceiling((float)count / sizePage);
                bindingSource.DataSource = Enumerable.Range(1, pageLength);
            }
        }
    }
}
