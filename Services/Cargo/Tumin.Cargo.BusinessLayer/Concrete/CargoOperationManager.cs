using System.Linq.Expressions;
using Tumin.Cargo.BusinessLayer.Abstract;
using Tumin.Cargo.DataAccessLayer.Abstract;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.BusinessLayer.Concrete;

public class CargoOperationManager : ICargoOperationService
{
    private readonly ICargoOperationDal _cargoOperationDal;

    public CargoOperationManager(ICargoOperationDal cargoOperationDal)
    {
        _cargoOperationDal = cargoOperationDal;
    }

    public async Task<List<CargoOperation>> TGetAllAsync()
    {
        return await _cargoOperationDal.GetAllAsync();
    }

    public async Task<CargoOperation> TGetByIdAsync(int id)
    {
        return await _cargoOperationDal.GetByIdAsync(id);
    }

    public async Task<CargoOperation> TCreateAsync(CargoOperation entity)
    {
        return await _cargoOperationDal.CreateAsync(entity);
    }

    public async Task<CargoOperation> TUpdateAsync(CargoOperation entity)
    {
        return await _cargoOperationDal.UpdateAsync(entity);
    }

    public async Task<CargoOperation> TDeleteAsync(int id)
    {
        return await _cargoOperationDal.DeleteAsync(id);
    }
    
}