using AutoMapper;
using CafeManagement.Business.DTOs;
using CafeManagement.Domain.Repositories.Menu;

namespace CafeManagement.Business.Services.Menu;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<List<CategoryDto>> GetCategories()
    {
        var categories = await _categoryRepository.GetAllAsync();
        return _mapper.Map<List<CategoryDto>>(categories);
    }

    public async Task<CategoryDto> GetCategory(int categoryId)
    {
        var category = await _categoryRepository.FindAsync(categoryId);
        return _mapper.Map<CategoryDto>(category);
    }
}