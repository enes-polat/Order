using ECommerce.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Fields
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        #endregion

        #region Constructor
        public Repository(ECommerceContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext can not be null.");
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        #endregion

        #region Methods

        public T Add(T entity)
        {
            T model = _dbSet.Add(entity).Entity;
            _dbContext.SaveChanges();
            return model;
        }
        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();

        }

        public void Delete(T entity)
        {
            _dbSet.Attach(entity);
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();

        }

        public async Task<T> GetAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await _dbSet.SingleOrDefaultAsync(match);
        }


        #endregion
    }
}
