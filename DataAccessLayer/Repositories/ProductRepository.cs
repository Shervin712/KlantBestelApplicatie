using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MatrixIncDbContext _context;

        public ProductRepository(MatrixIncDbContext context) 
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products
                .Include(p => p.Parts)
                .Include(p => p.Category);
        }

        public Product? GetProductById(int id)
        {
            return _context.Products
                .Include(p => p.Parts)
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return _context.Products
                .Include(p => p.Parts)
                .Include(p => p.Category)
                .Where(p => p.Category != null && p.Category.Id == categoryId)
                .ToList();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
