using ECommerce.Core.Entities;
using ECommerce.Data.Repository;
using ECommerce.Service.Abstract;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Service.Concrete
{
    public class OrderDetailService : IOrderDetailService
    {
        #region Fields
        private readonly IRepository<OrderDetail> _orderDetailRepository;
        #endregion

        #region Ctor
        public OrderDetailService(IRepository<OrderDetail> orderDetailRepository)
        {
            this._orderDetailRepository = orderDetailRepository;
        }
        #endregion

        #region Methods
        public OrderDetail Add(OrderDetail entity)
        {
            _orderDetailRepository.Add(entity);
            return entity;
        }

        public void Delete(OrderDetail entity)
        {
            _orderDetailRepository.Delete(entity);
        }

        public async Task<OrderDetail> GetAsync(int id)
        {
            return await _orderDetailRepository.GetAsync(id);
        }

        public void Update(OrderDetail entity)
        {
            _orderDetailRepository.Update(entity);
        }
        public Task<OrderDetail> FindAsync(Expression<Func<OrderDetail, bool>> match)
        {
            return _orderDetailRepository.FindAsync(match);
        }
        #endregion
    }
}
