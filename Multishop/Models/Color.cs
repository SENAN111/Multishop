namespace Multishop.Models
{
    public class Color
    {
        public string Name { get; set; }
        public ICollection<ProductColor> Colors { get; set;}
    }
}
