using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TourTest.Context.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }

        public string CountryCode { get; set; }
        public virtual Country Country { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }

        public Hotel()
        {
            Tours = new HashSet<Tour>();
        }

    }
}
