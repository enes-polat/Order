using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> GetAsync(int id);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
    }
}
