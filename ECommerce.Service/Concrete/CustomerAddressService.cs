using ECommerce.Core.Entities;
using ECommerce.Data.Repository;
using ECommerce.Service.Abstract;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Service.Concrete
{
    public class CustomerAddressService : ICustomerAddressService
    {
        #region Fields
        private readonly IRepository<CustomerAddress> _customerAddressRepository;

        #endregion

        #region Ctor
        public CustomerAddressService(IRepository<CustomerAddress> customerAddressRepository)
        {
            this._customerAddressRepository = customerAddressRepository;
        }
        #endregion

        #region Methods
        public CustomerAddress Add(CustomerAddress entity)
        {
            _customerAddressRepository.Add(entity);
            return entity;
        }

        public void Delete(CustomerAddress entity)
        {

            _customerAddressRepository.Delete(entity);
        }

        public async Task<CustomerAddress> GetAsync(int id)
        {
            return await _customerAddressRepository.GetAsync(id);
        }
        public void Update(CustomerAddress entity)
        {
            _customerAddressRepository.Update(entity);
        }

        public CustomerAddress GetById(int id)
        {
            return FindAsync(x => x.Id == id).Result;
        }

        public async Task<CustomerAddress> FindAsync(Expression<Func<CustomerAddress, bool>> match)
        {
            return await _customerAddressRepository.FindAsync(match);
        }

        #endregion
    }
}
