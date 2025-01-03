using AutoMapper;
using EComm.Domain.DTO;
using EComm.Domain.Entities;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CustomerDTO, CustomerEntity>();
        CreateMap<CustomerEntity, CustomerDTO>(); 
    }
}