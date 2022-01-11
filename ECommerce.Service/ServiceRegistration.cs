using AutoMapper;
using ECommerce.Service.Abstract;
using ECommerce.Service.Concrete;
using ECommerce.Service.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Service
{
    public static class ServiceRegistration
    {
        public static void AddServiceRegistration(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ICustomerAddressService, CustomerAddressService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IOrderDetailService, OrderDetailService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOperationService, OperationService>();
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ECommerceMappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}