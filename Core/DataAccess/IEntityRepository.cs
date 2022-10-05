using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess
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
