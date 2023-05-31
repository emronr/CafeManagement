using AutoMapper;
using CafeManagement.Business.DTOs;
using CafeManagement.Domain.Entities;

namespace CafeManagement.Business.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        this.CreateMap(typeof(BaseEntity<>), typeof(BaseDTO));
        
    }
}