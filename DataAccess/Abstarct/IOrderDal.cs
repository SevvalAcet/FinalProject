using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstarct
{
    public interface IOrderDal:IEntityRepository<Order>
    {
    }
}
