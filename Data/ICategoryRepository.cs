using System.Collections.Generic;
using System.Threading.Tasks;

namespace aspnetcoregraphql
{
    public interface ICategoryRepository
    {
        Task<List<Category>> CategoriesAsync();
        Task<Category> GetCategoryAsync(int id);
    }
}