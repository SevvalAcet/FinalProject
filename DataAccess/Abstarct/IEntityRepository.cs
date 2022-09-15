
using Entities.Abstact;
using System.Linq.Expressions;

namespace DataAccess.Abstarct
{    //generic constraint:kısıtlama
    //class:referans tip olabilir
    public interface IEntityRepository<T> where T : class, IEntity,new()
    {               //expression:filtreleme yapmamızı sağlıyor
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T,bool>>filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
