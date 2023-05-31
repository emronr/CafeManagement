namespace CafeManagement.Business.DTOs;

public class CategoryDto : BaseDTO
{
    public string Name { get; set; }

    public List<ProductDto> Products { get; set; }
}