using CafeManagement.Domain.Entities.Menu;
using CafeManagement.Domain.Entities.Order;

namespace CafeManagement.Business.DTOs;

public class OrderDetailDto : BaseDTO
{
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public int OrderId { get; set; }
    public Order Order { get; set; }
}