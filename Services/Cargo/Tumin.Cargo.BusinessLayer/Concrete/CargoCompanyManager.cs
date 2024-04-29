using System.Linq.Expressions;
using Tumin.Cargo.BusinessLayer.Abstract;
using Tumin.Cargo.DataAccessLayer.Abstract;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.BusinessLayer.Concrete;

public class CargoCompanyManager : ICargoCompanyService
{
    private readonly ICargoCompanyDal _cargoCompanyDal;

    public CargoCompanyManager(ICargoCompanyDal cargoCompanyDal)
    {
        _cargoCompanyDal = cargoCompanyDal;
    }

    public async Task<List<CargoCompany>> TGetAllAsync()
    {
        return await _cargoCompanyDal.GetAllAsync();
    }

    public async Task<CargoCompany> TGetByIdAsync(int id)
    {
        return await _cargoCompanyDal.GetByIdAsync(id);
    }

    public async Task<CargoCompany> TCreateAsync(CargoCompany entity)
    {
        return await _cargoCompanyDal.CreateAsync(entity);
    }

    public async Task<CargoCompany> TUpdateAsync(CargoCompany entity)
    {
        return await _cargoCompanyDal.UpdateAsync(entity);
    }

    public async Task<CargoCompany> TDeleteAsync(int id)
    {
        return await _cargoCompanyDal.DeleteAsync(id);
        
    }

}