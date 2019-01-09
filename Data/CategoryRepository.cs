using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphqlSample.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetcoregraphql.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> _categories;
 
         private ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
 
        public Task<List<Category>> CategoriesAsync()
        {
            return _context.Categories.ToListAsync();
        }
 
        public Task<Category> GetCategoryAsync(int id)
        {
            return _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}