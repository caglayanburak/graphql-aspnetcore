using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphqlSample.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetcoregraphql.Data
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;
        private ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Product> GetProductAsync(int id)
        {
            return _context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<Product>> GetProductsAsync()
        {
            return Task.FromResult(_products);
        }

        public Task<List<Product>> GetProductsWithByCategoryIdAsync(int categoryId)
        {
            return _context.Products.Where(x => x.CategoryId == categoryId).ToListAsync();
        }
    }
}