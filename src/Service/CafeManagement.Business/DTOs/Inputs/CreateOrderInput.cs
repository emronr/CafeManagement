namespace CafeManagement.Business.DTOs.Inputs
{
    public class CreateOrderInput
    {
        public int TableId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
