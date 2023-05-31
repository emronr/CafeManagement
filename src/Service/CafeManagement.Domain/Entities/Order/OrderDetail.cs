using CafeManagement.Domain.Entities.Menu;

namespace CafeManagement.Domain.Entities.Order
{
    public class OrderDetail : BaseEntity<int>
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

    }
}
