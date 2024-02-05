using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TourTest.Context.Models
{
    public class ReceivingPoint
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
