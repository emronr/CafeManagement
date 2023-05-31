using CafeManagement.Business.DTOs;

namespace CafeManagement.Business.Services.Menu;

public interface IProductService
{
    /// <summary>
    /// Tüm ürünleri getirir.
    /// </summary>
    /// <returns></returns>
    Task<List<ProductDto>> GetProducts();

    /// <summary>
    /// Ürünü getirir.
    /// </summary>
    /// <param name="productId"></param>
    /// <returns></returns>
    Task<ProductDto> GetProduct(int productId);

    /// <summary>
    /// Kategori altındaki ürünleri getirir.
    /// </summary>
    /// <param name="categoryId"></param>
    /// <returns></returns>
    List<ProductDto> GetProducts(int categoryId);
}