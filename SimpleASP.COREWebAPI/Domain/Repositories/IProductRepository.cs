using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnApi.Domain.Models;

namespace LearnApi.Domain.Repositories
{
    public interface IProductRepository
    {

        Task<IEnumerable<Product>> ListAsync();
        Task AddAsync(Product category);
        Task<Product> FindByIdAsync(int id);
        void Update(Product category);
        void Remove(Product category);
    }
}
