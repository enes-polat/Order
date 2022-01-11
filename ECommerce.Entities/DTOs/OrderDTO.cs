namespace ECommerce.Entities.DTOs
{
    public class OrderDTO
    {
        //Property
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Stock { get; set; }
        public string Status { get; set; }

        //Navigation Property
        public CustomerDTO CustomerDTO { get; set; }
        public BillingDTO BillingDTO { get; set; }
    }
}
