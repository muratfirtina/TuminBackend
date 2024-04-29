using AutoMapper;
using Tumin.Cargo.DtoLayer.CargoDetailDtos;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.DtoLayer.Mapping;

public class CargoDetailMappingProfile : Profile
{
    public CargoDetailMappingProfile()
    {
        CreateMap<CargoDetail, CreateCargoDetailDto>().ReverseMap();
        CreateMap<CargoDetail, UpdateCargoDetailDto>().ReverseMap();
    }
}