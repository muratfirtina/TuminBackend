using AutoMapper;
using Tumin.Cargo.DtoLayer.CargoCustomerDtos;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.DtoLayer.Mapping;

public class CargoCustomerMappingProfile : Profile
{
    public CargoCustomerMappingProfile()
    { 
        CreateMap<CargoCustomer, CreateCargoCustomerDto>().ReverseMap();
        CreateMap<CargoCustomer, UpdateCargoCustomerDto>().ReverseMap();
    }
}