using ECommerce.Core.Entities.Concrete;

namespace ECommerce.Core.Entities
{
    public class OrderDetail : EntityBase<int>
    {
        // Property
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        // Navigation Property
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
