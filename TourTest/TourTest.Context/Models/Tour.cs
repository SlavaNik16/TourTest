using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTest.Context.Models
{
    public class Tour
    {
        public int Id { get; set; }

        public int TicketCount { get; set; }

        public string Name { get; set; } 

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsActual { get; set; }

        public byte[] ImagePreview { get; set; }

        public ICollection<Hotel> Hotels { get; set; }

        public Tour()
        {
            Hotels = new HashSet<Hotel>();
        }

    }
}
