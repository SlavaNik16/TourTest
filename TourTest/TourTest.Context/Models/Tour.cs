using System.Collections.Generic;

namespace TourTest.Context.Models
{
    public class Tour
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CountryCode { get; set; }
        public Country Country { get; set; }

        public int TicketCount { get; set; }

        public decimal Price { get; set; }

        public bool IsActual { get; set; } = true;

        public string Description { get; set; }

        public byte[] ImagePreview { get; set; }

        public ICollection<Hotel> Hotels { get; set; }

        public ICollection<Type> Types { get; set; }

        public Tour()
        {
            Hotels = new HashSet<Hotel>();
            Types = new HashSet<Type>();
        }

    }
}
