﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CentSia.Models;

namespace CentSia.Logic
{
    public class AddProducts
    {
        public bool AddProduct(string ProductName, string ProductAuthor, string ProductDesc, string ProductPrice, string ProductCategory, string ProductImagePath)
        {
            var myProduct = new Product();
            myProduct.ProductName = ProductName;
            myProduct.Author = ProductAuthor;
            myProduct.Description = ProductDesc;
            myProduct.Price = Convert.ToDouble(ProductPrice);
            myProduct.ImagePath = ProductImagePath;
            myProduct.CategoryID = Convert.ToInt32(ProductCategory);

            using (ProductContext _db = new ProductContext())
            {
                // Add product to DB.
                _db.Products.Add(myProduct);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }
    }
}