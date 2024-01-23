using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTest.Context.Models
{
    public class Type
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Tour> Tours { get; set; }

        public Type()
        {
            Tours = new HashSet<Tour>();
        }
    }
}
