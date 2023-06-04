namespace CafeManagement.Business.DTOs.Inputs
{
    public class CreateProductInput
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
