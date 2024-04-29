using System.Linq.Expressions;
using Tumin.Cargo.BusinessLayer.Abstract;
using Tumin.Cargo.DataAccessLayer.Abstract;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.BusinessLayer.Concrete;

public class CargoCustomerManager : ICargoCustomerService
{
    private readonly ICargoCustomerDal _cargoCustomerDal;

    public CargoCustomerManager(ICargoCustomerDal cargoCustomerDal)
    {
        _cargoCustomerDal = cargoCustomerDal;
    }

    public async Task<List<CargoCustomer>> TGetAllAsync()
    {
        return await _cargoCustomerDal.GetAllAsync();
    }

    public async Task<CargoCustomer> TGetByIdAsync(int id)
    {
        return await _cargoCustomerDal.GetByIdAsync(id);
    }

    public async Task<CargoCustomer> TCreateAsync(CargoCustomer entity)
    {
        return await _cargoCustomerDal.CreateAsync(entity);
    }

    public async Task<CargoCustomer> TUpdateAsync(CargoCustomer entity)
    {
        return await _cargoCustomerDal.UpdateAsync(entity);
    }

    public async Task<CargoCustomer> TDeleteAsync(int id)
    {
        return await _cargoCustomerDal.DeleteAsync(id);
    }

}