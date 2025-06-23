using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Relatie naar Product
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}