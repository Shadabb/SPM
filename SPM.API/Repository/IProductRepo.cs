using SPM.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.API.Repository
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void CreateProduct(Product product);
        void UpdateProduct(Product updateProduct);
        void DeleteProduct(Product product);

        bool SaveChanges();
    }
}
