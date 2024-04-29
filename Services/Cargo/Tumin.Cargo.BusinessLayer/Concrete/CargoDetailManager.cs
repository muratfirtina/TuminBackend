using System.Linq.Expressions;
using Tumin.Cargo.BusinessLayer.Abstract;
using Tumin.Cargo.DataAccessLayer.Abstract;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.BusinessLayer.Concrete;

public class CargoDetailManager : ICargoDetailService
{
    private readonly ICargoDetailDal _cargoDetailDal;

    public CargoDetailManager(ICargoDetailDal cargoDetailDal)
    {
        _cargoDetailDal = cargoDetailDal;
    }

    public async Task<List<CargoDetail>> TGetAllAsync()
    {
        return await _cargoDetailDal.GetAllAsync();
    }

    public async Task<CargoDetail> TGetByIdAsync(int id)
    {
        return await _cargoDetailDal.GetByIdAsync(id);
    }

    public async Task<CargoDetail> TCreateAsync(CargoDetail entity)
    {
        return await _cargoDetailDal.CreateAsync(entity);
    }

    public async Task<CargoDetail> TUpdateAsync(CargoDetail entity)
    {
        return await _cargoDetailDal.UpdateAsync(entity);
    }

    public async Task<CargoDetail> TDeleteAsync(int id)
    {
        return await _cargoDetailDal.DeleteAsync(id);
    }

}