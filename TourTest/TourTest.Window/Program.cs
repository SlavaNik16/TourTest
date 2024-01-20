using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourTest.Context.DB;
using TourTest.Context.Models;

namespace TourTest.Window
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form1 = new Form1();
            using (var db = new TourContext())
            {
                var tour = db.Tours.FirstOrDefault();

                form1.pictureBox1.Image = Image.FromStream(new MemoryStream(tour.ImagePreview));
            }
            Application.Run(form1);
        }
    }
}
