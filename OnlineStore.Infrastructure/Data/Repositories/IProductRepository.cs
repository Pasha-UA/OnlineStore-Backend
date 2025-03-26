using OnlineStore.Infrastructure.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.Infrastructure.Data.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<Product> Add(Product product);
        Task Update(Product product);
        Task Delete(int id);
    }
}