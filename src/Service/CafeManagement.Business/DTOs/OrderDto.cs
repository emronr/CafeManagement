namespace CafeManagement.Business.DTOs;

public class OrderDto : BaseDTO
{
    public int TableId { get; set; }
    public TableDto Table { get; set; }
    public List<OrderDetailDto> OrderDetails { get; set; } 

    public DateTime CreateDate { get; set; }
    public DateTime LastOrderDate { get; set; }
    public DateTime? PaymentDate { get; set; }


    public decimal GetTotalPrice()
    {
        return OrderDetails.Select(x => x.Product.Price * x.Quantity).Sum();
    }
}