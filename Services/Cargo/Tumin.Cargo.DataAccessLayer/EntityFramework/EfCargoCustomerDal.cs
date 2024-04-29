using Tumin.Cargo.DataAccessLayer.Abstract;
using Tumin.Cargo.DataAccessLayer.Concrete;
using Tumin.Cargo.DataAccessLayer.Repositories;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.DataAccessLayer.EntityFramework;

public class EfCargoCustomerDal : GenericRepository<CargoCustomer>, ICargoCustomerDal
{
    public EfCargoCustomerDal(CargoDbContext context) : base(context)
    {
        
    }
}