using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TourTest.Context.Models
{
    public class Type
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }

        public Type()
        {
            Tours = new HashSet<Tour>();
        }
    }
}
