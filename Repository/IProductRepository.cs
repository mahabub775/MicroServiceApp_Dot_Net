using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductMicroService.Models;

namespace ProductMicroService.Repository
{
    interface IProductRepository
    {

        IEnumerable<Product> GetProducts();
        Product GetProduct(int ProductId);
        void InsertProduct(Product Product);
        void UpdateProduct(Product Product);
        void DeleteProduct(int ProductId);
        void Save();

    }
}
