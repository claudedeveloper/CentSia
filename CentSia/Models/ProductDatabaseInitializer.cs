using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CentSia.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
       // DropCreateDatabaseAlways<ProductContext>
       // DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private List<Category> GetCategories()
        {
            //CategoryID, CategoryName, Description
            var categories = new List<Category> {
                new Category {CategoryID = 1, CategoryName = "Fiction"},
                new Category {CategoryID = 2, CategoryName = "Non-Fiction"},
                new Category {CategoryID = 3, CategoryName = "Reference"},
            };
            return categories;
        }

        private List<Product> GetProducts()
        {
            //ProductID, ProductName, Description, Author, Price, Category ID
            var products = new List<Product> {
                new Product 
                {
                    ProductID=1, 
                    ProductName="War and Peace", 
                    Description="a novel about 18th century Europe",
                    Author="Tolstoy Lev Nikolayevich",
                    Price=324.60,
                    ImagePath="warandpeace.jpg",
                    CategoryID=1
                },
                new Product
                {
                    ProductID=2, 
                    ProductName="The Diary of a Young Girl", 
                    Description="the diary of Anne Frank during Nazi Germany occupation",
                    Author="Anne Frank",
                    Price=89.50,
                    ImagePath="diaryanne.jpg",
                    CategoryID=2
                },
                new Product
                {
                    ProductID=3, 
                    ProductName="Electronics Theory", 
                    Description="covers basic electronics concept for engineers",
                    Author="Louis Boylestad",
                    Price=89.50,
                    ImagePath="electronicdevices.jpg",
                    CategoryID=3
                },
            };
            return products;
        }
    }
}