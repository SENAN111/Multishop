namespace Multishop.Models
{
    public class ProductInformation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public Product? product { get; set;}

    }
}
