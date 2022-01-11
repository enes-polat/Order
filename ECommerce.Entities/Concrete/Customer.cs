using ECommerce.Core.Entities.Concrete;

namespace ECommerce.Core.Entities
{
    public class Customer : EntityBase<int>
    {
        // Property
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public string MailAddress { get; set; }
    }
}
