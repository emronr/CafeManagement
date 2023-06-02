using CafeManagement.Business.DTOs;
using CafeManagement.Business.DTOs.Inputs;

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

    /// <summary>
    /// Ürün ekler.
    /// </summary>
    /// <param name="createProductInput"></param>
    /// <returns></returns>
    Task<int> CreateProductAsync(CreateProductInput createProductInput);

    /// <summary>
    /// Ürünü günceller
    /// </summary>
    /// <param name="productDto"></param>
    /// <returns></returns>
    Task UpdateProductAsync(ProductDto productDto);
}