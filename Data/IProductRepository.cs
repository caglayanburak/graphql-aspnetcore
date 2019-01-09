using System.Collections.Generic;
using System.Threading.Tasks;

namespace aspnetcoregraphql
{
     public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();
        Task<List<Product>> GetProductsWithByCategoryIdAsync(int categoryId);
        Task<Product> GetProductAsync(int id);
    }
}