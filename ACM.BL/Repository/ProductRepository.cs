﻿using System;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            //Create the instance of hte product class.
            //Pass in the requested Id.
            Product product = new Product(productId);

            //Code that retrieves the defined product.

            //Temporary hard-coded values to return a populated product.
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"product: {product.ToString()}");
            return product;
        }

        //Saves the current product.
        public bool Save(Product product)
        {
            //Code that saves the passed in product.
            var success = true;

            if (product.HasChanges)
            {
                if (product.HasChanges)
                {
                    if (product.IsNew)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
