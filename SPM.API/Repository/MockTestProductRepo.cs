using SPM.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.API.Repository
{
    public class MockTestProductRepo : IProductRepo
    {
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    ProductName = "Leaf Rake",
                    ProductCode = "GDN-0011",
                    ReleaseDate = "March 19, 2018",
                    Description = "Leaf rake with 48-inch wooden handle",
                    Price = "19.95",
                    StarRating = "3.2",
                    ImageUrl = "assets/images/leaf_rake.png"
                },
                new Product
                {
                    Id = 2,
                    ProductName = "Garden Cart",
                    ProductCode = "GDN-0023",
                    ReleaseDate = "March 18, 2018",
                    Description = "15 gallon capacity rolling garden cart",
                    Price = "32.99",
                    StarRating = "4.2",
                    ImageUrl = "assets/images/garden_cart.png"
                }
            };

            return products;
        }

        public Product GetProductById(int id)
        {
            return new Product
            {
                Id = 1,
                ProductName = "Leaf Rake",
                ProductCode = "GDN-0011",
                ReleaseDate = "March 19, 2018",
                Description = "Leaf rake with 48-inch wooden handle",
                Price = "19.95",
                StarRating = "3.2",
                ImageUrl = "assets/images/leaf_rake.png"
            };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product updateProduct)
        {
            throw new NotImplementedException();
        }
    }
}
