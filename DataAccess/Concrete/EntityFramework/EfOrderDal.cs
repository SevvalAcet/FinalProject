using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {
    
    }
}
