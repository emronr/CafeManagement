using System.Net;
using CafeManagement.Business.DTOs;
using CafeManagement.Business.DTOs.Inputs;
using CafeManagement.Business.Services.Menu;
using CafeManagement.Common.Models.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace CafeManagement.API.Controllers;

[ApiController]
[Route("api/v1/cafe-mangement/menu")]
[ProducesResponseType(typeof(BaseResponse), (int)HttpStatusCode.BadRequest)]
public class MenuController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;
    
    public MenuController(IProductService productService,
        ICategoryService categoryService)
    {
        _categoryService = categoryService;
        _productService = productService;
    }

    [HttpGet("categories")]
    [ProducesResponseType(typeof(BaseResponse<List<CategoryDto>>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetCategories()
    {
        return Ok(new BaseResponse<List<CategoryDto>>(await _categoryService.GetCategories()));
    }
    
    [HttpGet("categories/{categoryId}/products")]
    [ProducesResponseType(typeof(BaseResponse<List<ProductDto>>), (int)HttpStatusCode.OK)]
    public IActionResult GetProducts(int categoryId)
    {
        return Ok(new BaseResponse<List<ProductDto>>(_productService.GetProducts(categoryId)));
    }
    
    [HttpGet("products")]
    [ProducesResponseType(typeof(BaseResponse<List<ProductDto>>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetProducts()
    {
        return Ok(new BaseResponse<List<ProductDto>>(await _productService.GetProducts()));
    }
    
    [HttpPost("products")]
    [ProducesResponseType(typeof(BaseResponse<int>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductInput createProductInput)
    {
        return Ok(new BaseResponse<int>(await _productService.CreateProductAsync(createProductInput)));
    }
    
    [HttpPatch("products/{productId}")]
    [ProducesResponseType(typeof(BaseResponse<string>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> UpdateProduct([FromBody] ProductDto productDto)
    {
        await _productService.UpdateProductAsync(productDto);
        return Ok(new BaseResponse<string>("OK"));
    }
}