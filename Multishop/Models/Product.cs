namespace Multishop.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public double price { get; set; }
        public double CostPrice { get; set; }
        public double SellPrice { get; set; }
        public ICollection<ProductColor> ProductColors { get; set;}
        public ICollection<ProductSize> ProductSizes { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ProductInformation? ProductInformations { get; set; }
        public List<Discount> Discounts { get; set; }
    }
}
