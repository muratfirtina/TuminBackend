using AutoMapper;
using Tumin.Cargo.DtoLayer.CargoCompanyDtos;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.DtoLayer.Mapping;

public class CargoCompanyMappingProfile : Profile
{
    public CargoCompanyMappingProfile()
    {
        CreateMap<CargoCompany, DeleteCargoCompanyDto>().ReverseMap();
        CreateMap<CargoCompany, CreateCargoCompanyDto>().ReverseMap();
        CreateMap<CargoCompany, UpdateCargoCompanyDto>().ReverseMap();
        CreateMap<CargoCompany, GetAllCargoCompanyDto>().ReverseMap();
        CreateMap<CargoCompany, GetCargoCompanyByIdDto>().ReverseMap();
    }
    
}