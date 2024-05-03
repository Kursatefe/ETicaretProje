﻿using Entities;
using System.Collections.Generic;

namespace Service
{
    public interface IProductService
    {
        
        IEnumerable<Product> GetAllProducts();

      
        Product GetProductById(int id);

        
        void AddProduct(Product product);

       
        void UpdateProduct(Product product);

        
        void DeleteProduct(int id);
    }
}
