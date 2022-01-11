using ECommerce.Core.Entities.Concrete;

namespace ECommerce.Core.Entities
{
    public class CustomerAddress : EntityBase<int>
    {
        // Property
        public string AddressName { get; set; }
        public int CustomerId { get; set; }

        //Navigation Property
        public virtual Customer Customer { get; set; }
    }
}
