using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TourTest.Context.Models
{
    public class Country
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Hotel> Hotel { get; set; }

        public virtual ICollection<Tour> Tour { get; set; }

    }
}
