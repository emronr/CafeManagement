using System;
using System.Collections.Generic;
using System.Linq;
using CafeManagement.Domain.Entities.Cafe;

namespace CafeManagement.Domain.Entities.Order
{
    public class Order : BaseEntity<int>
    {
        public int TableId { get; set; }
        public Table Table { get; set; }
        public List<OrderDetail> OrderDetails { get; set; } 

        public DateTime CreateDate { get; set; }
        public DateTime LastOrderDate { get; set; }
        public DateTime? PaymentDate { get; set; }


        public decimal GetTotalPrice()
        {
            return OrderDetails.Select(x => x.Product.Price * x.Quantity).Sum();
        }
    }
}
