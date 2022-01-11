using AutoMapper;
using ECommerce.Core.Entities;
using ECommerce.Entities.DTOs;

namespace ECommerce.Service.Mappings
{
    public class ECommerceMappingProfile : Profile
    {
        #region Ctor
        public ECommerceMappingProfile()
        {
            CreateMap<Order, OrderDTO>();
            CreateMap<Order, OrderDTO>();

            CreateMap<Customer, CustomerDTO>().ForMember(o => o.CustomerId, b => b.MapFrom(z => z.Id));
            CreateMap<CustomerDTO, Customer>().ForMember(o => o.Id, b => b.MapFrom(z => z.CustomerId));
            #endregion
        }
    }
}
