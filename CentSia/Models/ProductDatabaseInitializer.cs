using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CentSia.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
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
                    Description="A novel about 18th century Europe",
                    Author="Tolstoy Lev Nikolayevich",
                    Price=324.60,
                    ImagePath="warandpeace.jpg",
                    CategoryID=1
                },
                new Product
                {
                    ProductID=2, 
                    ProductName="The Diary of a Young Girl", 
                    Description="The diary of Anne Frank during Nazi Germany occupation",
                    Author="Anne Frank",
                    Price=89.50,
                    ImagePath="diaryanne.jpg",
                    CategoryID=2
                },
                new Product
                {
                    ProductID=3, 
                    ProductName="Electronics Theory", 
                    Description="Covers basic electronics concept for engineers",
                    Author="Louis Boylestad",
                    Price=89.50,
                    ImagePath="electronicdevices.jpg",
                    CategoryID=3
                },
                new Product
                {
                    ProductID=4, 
                    ProductName="Think and Grow Rich", 
                    Description="The Entrepreneur and Small Business Owner’s Edition of the Best-Selling Classic, Think and Grow Rich, By Napoleon Hill",
                    Author="Greg Habstritt & Napoleon Hill",
                    Price=450.50,
                    ImagePath="think.jpeg",
                    CategoryID=3
                },
                new Product
                {
                    ProductID=5, 
                    ProductName="A Little Bit of Everything For Dummies", 
                    Description="Twenty years ago the very first For Dummies book, DOS For Dummies, was published. From that first printing of that first book came a series unlike anything in the publishing world, one that is global in both geography - we have been published worldwide in some 30 languages - and in coverage. ",
                    Author="John Wiley & Sons, Inc.",
                    Price=500,
                    ImagePath="dummies.jpeg",
                    CategoryID=3
                },
                new Product
                {
                    ProductID=6, 
                    ProductName="Another 100 Quotations to Think About", 
                    Description="Once again, this is a collection of various quotations from unknown authors. Some serious, others funny, and some insightful.",
                    Author="Wolfgang Riebe",
                    Price=100,
                    ImagePath="another.jpeg",
                    CategoryID=3
                },
                new Product
                {
                    ProductID=7, 
                    ProductName="Lose Weight Without Dieting", 
                    Description="Learn How To Use The Power Of Your Mind To Achieve Real, Natural Weight Loss.",
                    Author="David Nordmark",
                    Price=500,
                    ImagePath="diet.jpeg",
                    CategoryID=3
                },
            };
            return products;
        }
    }
}