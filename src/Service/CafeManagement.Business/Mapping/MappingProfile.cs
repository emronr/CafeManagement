using AutoMapper;
using CafeManagement.Business.DTOs;
using CafeManagement.Business.DTOs.Inputs;
using CafeManagement.Domain.Entities;
using CafeManagement.Domain.Entities.Cafe;
using CafeManagement.Domain.Entities.Menu;
using CafeManagement.Domain.Entities.Order;

namespace CafeManagement.Business.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        this.CreateMap(typeof(BaseEntity<>), typeof(BaseDTO));
        this.CreateMap<Table, TableDto>();
        this.CreateMap<Category, CategoryDto>();
        this.CreateMap<Order, OrderDto>();
        this.CreateMap<OrderDetail, OrderDetailDto>();
        this.CreateMap<Product, ProductDto>().ReverseMap();
        this.CreateMap<CreateProductInput, Product>();
    }
}