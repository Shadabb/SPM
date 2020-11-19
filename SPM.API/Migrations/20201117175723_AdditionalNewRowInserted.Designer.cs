﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SPM.API.Data;

namespace SPM.API.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20201117175723_AdditionalNewRowInserted")]
    partial class AdditionalNewRowInserted
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SPM.API.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ReleaseDate")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StarRating")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Leaf rake with 48-inch wooden handle",
                            ImageUrl = "assets/images/leaf_rake.png",
                            Price = "19.95",
                            ProductCode = "GDN-0011",
                            ProductName = "Leaf Rake",
                            ReleaseDate = "March 19, 2018",
                            StarRating = "3.2"
                        },
                        new
                        {
                            Id = 2,
                            Description = "15 gallon capacity rolling garden cart",
                            ImageUrl = "assets/images/garden_cart.png",
                            Price = "32.99",
                            ProductCode = "GDN-0023",
                            ProductName = "Garden Cart",
                            ReleaseDate = "March 18, 2018",
                            StarRating = "4.2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Curved claw steel hammer",
                            ImageUrl = "assets/images/hammer.png",
                            Price = "8.9",
                            ProductCode = "TBX-0048",
                            ProductName = "Hammer",
                            ReleaseDate = "May 21, 2018",
                            StarRating = "4.8"
                        },
                        new
                        {
                            Id = 4,
                            Description = "15-inch steel blade hand saw",
                            ImageUrl = "assets/images/saw.png",
                            Price = "11.55",
                            ProductCode = "TBX-0022",
                            ProductName = "Saw",
                            ReleaseDate = "May 15, 2018",
                            StarRating = "3.7"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Standard two-button video game controller",
                            ImageUrl = "assets/images/xbox-controller.png",
                            Price = "35.95",
                            ProductCode = "GMG-0042",
                            ProductName = "Video Game Controller",
                            ReleaseDate = "October 15, 2018",
                            StarRating = "4.6"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
