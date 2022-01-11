using ECommerce.Core.Entities;
using ECommerce.Data.Repository;
using ECommerce.Service.Abstract;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Service.Concrete
{
    public class ProductService : IProductService
    {
        #region Fields
        private readonly IRepository<Product> _productRepository;
        #endregion

        #region Ctor
        public ProductService(IRepository<Product> productRepository)
        {
            this._productRepository = productRepository;
        }
        #endregion

        #region Methods
        public Product Add(Product entity)
        {
            _productRepository.Add(entity);
            return entity;
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public async Task<Product> GetAsync(int id)
        {
            return await _productRepository.GetAsync(id);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }

        public async Task<Product> FindAsync(Expression<Func<Product, bool>> match)
        {
            return await _productRepository.FindAsync(match);
        }
        #endregion
    }
}
