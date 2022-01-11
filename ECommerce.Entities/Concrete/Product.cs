using ECommerce.Core.Entities.Concrete;

namespace ECommerce.Core.Entities
{
    public class Product : EntityBase<int>
    {
        //Property
        public string Code { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}
