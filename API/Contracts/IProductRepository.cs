﻿using Application.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contracts
{
    public interface IProductRepository : IBaseRepository<Product>
    {

        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        void Update(Data.Entities.Product product);
        void CreateProduct(Data.Entities.Product product);
    }
}
