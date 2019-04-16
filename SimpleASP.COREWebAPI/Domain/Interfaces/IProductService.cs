using System.Collections.Generic;
using System.Threading.Tasks;
using LearnApi.Domain.Models;
using LearnApi.Resources;
using LearnApi.Services.Communication;

namespace LearnApi.Domain.Interfaces
{
    public interface IProductService
    {

        Task<IEnumerable<Product>> ListAsync();
        Task<ProductResponse> SaveAsync(Product category);
        Task<ProductResponse> UpdateAsync(int id, Product category);
        Task<ProductResponse> DeleteAsync(int id);
    }
}
