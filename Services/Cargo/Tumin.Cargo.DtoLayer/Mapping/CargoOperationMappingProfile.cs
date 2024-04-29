using AutoMapper;
using Tumin.Cargo.DtoLayer.CargoOperationDtos;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.DtoLayer.Mapping;

public class CargoOperationMappingProfile : Profile
{
    public CargoOperationMappingProfile()
    {
        CreateMap<CargoOperation, CreateCargoOperationDto>().ReverseMap();
        CreateMap<CargoOperation, UpdateCargoOperationDto>().ReverseMap();
    }
}