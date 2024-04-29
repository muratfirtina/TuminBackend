using Tumin.Cargo.DataAccessLayer.Abstract;
using Tumin.Cargo.DataAccessLayer.Concrete;
using Tumin.Cargo.DataAccessLayer.Repositories;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.DataAccessLayer.EntityFramework;

public class EfCargoOperationDal : GenericRepository<CargoOperation>, ICargoOperationDal
{
    public EfCargoOperationDal(CargoDbContext context) : base(context)
    {
    }
}
