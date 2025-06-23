using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ArticleNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

        public ICollection<Part> Parts { get; set; } = new List<Part>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}