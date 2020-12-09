namespace PizzaDataLibrary.Models
{
    public class PartnerProductModel
    {
        public int PartnerProductId { get; set; }
        public int ProductId { get; set; }
        public float ProductPartnerPrice { get; set; }
        public int ProductCount { get; set; }
    }
}
