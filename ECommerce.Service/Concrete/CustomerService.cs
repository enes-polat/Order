using ECommerce.Core.Entities;
using ECommerce.Data.Repository;
using ECommerce.Service.Abstract;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Service.Concrete
{
    public class CustomerService : ICustomerService
    {
        #region Fields
        private readonly IRepository<Customer> _customerepository;
        #endregion

        #region Ctor
        public CustomerService(IRepository<Customer> customerepository)
        {
            this._customerepository = customerepository;
        }
        #endregion

        #region Methods
        public Customer Add(Customer entity)
        {
            _customerepository.Add(entity);
            return entity;
        }

        public void Delete(Customer entity)
        {
            _customerepository.Delete(entity);
        }

        public async Task<Customer> GetAsync(int id)
        {
            return await _customerepository.GetAsync(id);
        }

        public void Update(Customer entity)
        {
            _customerepository.Update(entity);
        }

        public async Task<Customer> FindAsync(Expression<Func<Customer, bool>> match)
        {
            return  await _customerepository.FindAsync(match);
        }
        #endregion
    }
}