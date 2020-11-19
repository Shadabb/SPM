using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SPM.API.Models;

namespace SPM.API.Configuration
{
    public class ProductDataSeedingConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
                (
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
                    },
                    new Product
                    {
                        Id = 3,
                        ProductName =  "Hammer",
                        ProductCode = "TBX-0048",
                        ReleaseDate = "May 21, 2018",
                        Description = "Curved claw steel hammer",
                        Price = "8.9",
                        StarRating = "4.8",
                        ImageUrl = "assets/images/hammer.png"
                    },
                    new Product
                    {
                        Id = 4,
                        ProductName = "Saw",
                        ProductCode = "TBX-0022",
                        ReleaseDate = "May 15, 2018",
                        Description = "15-inch steel blade hand saw",
                        Price = "11.55",
                        StarRating = "3.7",
                        ImageUrl = "assets/images/saw.png"
                    },
                    new Product
                    {
                        Id = 5,
                        ProductName = "Video Game Controller",
                        ProductCode = "GMG-0042",
                        ReleaseDate = "October 15, 2018",
                        Description = "Standard two-button video game controller",
                        Price = "35.95",
                        StarRating = "4.6",
                        ImageUrl = "assets/images/xbox-controller.png"
                    }
                );

        }
    }
}
