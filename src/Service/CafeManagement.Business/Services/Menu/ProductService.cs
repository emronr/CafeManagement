using AutoMapper;
using CafeManagement.Business.DTOs;
using CafeManagement.Business.DTOs.Inputs;
using CafeManagement.Domain.Entities.Menu;
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

    public List<ProductDto> GetProducts(int categoryId)
    {
        var products =  _productRepository.Query().Where(x => x.CategoryId == categoryId);
        return _mapper.Map<List<ProductDto>>(products.ToList());
    }

    public async Task<int> CreateProductAsync(CreateProductInput createProductInput)
    {
        var product = _mapper.Map<Product>(createProductInput);
        var productEntity = await _productRepository.CreateAsync(product);
        return productEntity.Id;
    }

    public async Task UpdateProductAsync(ProductDto productDto)
    {
        var product = await _productRepository.FindAsync(productDto.Id);
        _productRepository.Update(_mapper.Map(productDto, product));
    }
}