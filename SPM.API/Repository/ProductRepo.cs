using SPM.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SPM.API.Data;

namespace SPM.API.Repository
{
    public class ProductRepo : IProductRepo
    {
        private readonly ProductContext _context;

        public ProductRepo(ProductContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public void CreateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            _context.Products.Add(product);
        }

        public void UpdateProduct(Product updateProduct)
        {
            //Nothing
        }

        public bool SaveChanges()
        { 
            return (_context.SaveChanges() >= 0);
        }

        public void DeleteProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            _context.Products.Remove(product);

        }
    }
}
