namespace Multishop.Models
{
    public class ProductColor
    {
        public int ColorId { get; set; }
        public int ProductId { get; set; }
        public Product? product { get; set; }
        public Category? category { get; set; }
    }
}
