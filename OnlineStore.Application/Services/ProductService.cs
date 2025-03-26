using OnlineStore.Application.Interfaces;
using OnlineStore.Application.Models;
using OnlineStore.Infrastructure.Data.Repositories;
using OnlineStore.Infrastructure.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace OnlineStore.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductModel>> GetAllProducts()
        {
            var products = await _productRepository.GetAll();
            return _mapper.Map<IEnumerable<ProductModel>>(products);
        }

        public async Task<ProductModel> GetProductById(int id)
        {
            var product = await _productRepository.GetById(id);
            return _mapper.Map<ProductModel>(product);
        }

        public async Task<ProductModel> CreateProduct(ProductModel productModel)
        {
            var productEntity = _mapper.Map<Product>(productModel);
            var createdProduct = await _productRepository.Add(productEntity);
            return _mapper.Map<ProductModel>(createdProduct);
        }

        public async Task UpdateProduct(int id, ProductModel productModel)
        {
            var existingProduct = await _productRepository.GetById(id);
            if (existingProduct == null)
            {
                throw new Exception("Product not found"); // Replace with a custom exception
            }
            _mapper.Map(productModel, existingProduct); // Update the existing entity
            await _productRepository.Update(existingProduct);
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _productRepository.GetById(id);
            if (product == null)
            {
                throw new Exception("Product not found"); // Replace with a custom exception
            }
            await _productRepository.Delete(id);
        }
    }
}