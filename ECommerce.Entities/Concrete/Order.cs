using ECommerce.Core.Entities.Concrete;
using System.Collections.Generic;

namespace ECommerce.Core.Entities
{
    public class Order : EntityBase<int>
    {

        #region Ctor
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        } 
        #endregion

        // Property
        public string OrderNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsActive { get; set; }

        public int CustomerId { get; set; }
        public int? CustomerAddressId { get; set; }

        ////Navigation Property
        public virtual Customer Customer { get; set; }
        public virtual CustomerAddress CustomerAddress { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
