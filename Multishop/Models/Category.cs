namespace Multishop.Models
{
    public class Category
    {
        public string Name { get; set; }
        public string ImageUrl { get;  set;  }
        public ICollection<ProductCategory>ProductCategories { get; set; }

    }
}
