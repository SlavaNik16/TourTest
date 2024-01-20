using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTest.Context.Models
{
    public class Country
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }

        //public ICollection<Hotel> Hotel { get; set; }
    }
}
