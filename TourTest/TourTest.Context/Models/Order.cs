using System;
using System.Collections.Generic;

namespace TourTest.Context.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }

        public decimal Price { get; set; }

        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;
        public int AllSale { get; set; } = 0;

        public DateTimeOffset DateReceipt { get; set; } = DateTimeOffset.Now.AddDays(3);

        public int ReceivingPointId { get; set; }
        public virtual ReceivingPoint ReceivingPoint { get; set; }

        public int Code { get; set; }


        public virtual ICollection<Tour> Tours { get; set; }

        public Order()
        {
            Tours = new HashSet<Tour>();
        }
    }
}
