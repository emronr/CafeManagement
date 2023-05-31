using CafeManagement.Business.DTOs;

namespace CafeManagement.Business.Services.Menu;

public interface ICategoryService
{
    /// <summary>
    /// Tüm kategorileri getirir.
    /// </summary>
    /// <returns></returns>
    Task<List<CategoryDto>> GetCategories();

    
    /// <summary>
    /// Kategoriyi getirir.
    /// </summary>
    /// <param name="categoryId"></param>
    /// <returns></returns>
    Task<CategoryDto> GetCategory(int categoryId);
}