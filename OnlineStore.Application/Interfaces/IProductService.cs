using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Application.Models;

namespace OnlineStore.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> GetAllProducts();
        Task<ProductModel> GetProductById(int id);
        Task<ProductModel> CreateProduct(ProductModel product);
        Task UpdateProduct(int id, ProductModel product);
        Task DeleteProduct(int id);
    }
}