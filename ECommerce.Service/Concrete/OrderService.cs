using ECommerce.Core.Entities;
using ECommerce.Data.Repository;
using ECommerce.Service.Abstract;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Service.Concrete
{
    public class OrderService : IOrderService
    {
        #region Fields
        private readonly IRepository<Order> _orderRepository;
        #endregion

        #region Ctor
        public OrderService(IRepository<Order> orderRepository)
        {
            this._orderRepository = orderRepository;
        }
        #endregion

        #region Methods
        public Order Add(Order entity)
        {
            _orderRepository.Add(entity);
            return entity;
        }

        public void Delete(Order entity)
        {
            _orderRepository.Delete(entity);
        }

        public async Task<Order> GetAsync(int id)
        {
            return await _orderRepository.GetAsync(id);
        }

        public void Update(Order entity)
        {
            _orderRepository.Update(entity);
        }

        public Task<Order> FindAsync(Expression<Func<Order, bool>> match)
        {
           return _orderRepository.FindAsync(match);
        }
        #endregion
    }
}
