using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstarct
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
