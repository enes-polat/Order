namespace ECommerce.Entities.DTOs
{
    public class BillingDTO
    {
        //Property
        public decimal ItemPrice { get; set; }
        public decimal[] Discrounts { get; set; }
        public decimal[] Taxes { get; set; }
        public decimal TotalCost { get; set; }

    }
}
