using System.Collections.Generic;

namespace TourTest.Context.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }

        public string CountryCode { get; set; }
        public Country Country { get; set; }

        public string Description { get; set; }

        public ICollection<Tour> Tours { get; set;}

        public Hotel()
        {
            Tours = new HashSet<Tour>();
        }

    }
}
