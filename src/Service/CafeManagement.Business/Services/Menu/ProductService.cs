using AutoMapper;
using CafeManagement.Business.DTOs;
using CafeManagement.Domain.Repositories.Menu;

namespace CafeManagement.Business.Services.Menu;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<List<ProductDto>> GetProducts()
    {
        var products = await _productRepository.GetAllAsync();
        return _mapper.Map<List<ProductDto>>(products);
    }

    public async Task<ProductDto> GetProduct(int productId)
    {
        var product = await _productRepository.FindAsync(productId);
        return _mapper.Map<ProductDto>(product);
    }

    public async Task<List<ProductDto>> GetProducts(int categoryId)
    {
        var products = await _productRepository.Query(x => x.CategoryId == categoryId);
        return _mapper.Map<List<ProductDto>>(products.ToList());
    }
}