using Tumin.Cargo.DataAccessLayer.Abstract;
using Tumin.Cargo.DataAccessLayer.Concrete;
using Tumin.Cargo.DataAccessLayer.Repositories;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.DataAccessLayer.EntityFramework;

public class EfCargoDetailDal : GenericRepository<CargoDetail>, ICargoDetailDal
{
    public EfCargoDetailDal(CargoDbContext context) : base(context)
    {
    }
}