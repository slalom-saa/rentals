using Slalom.Stacks.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slalom.Rentals.Application.Catalog.Products.Add
{
    /// <summary>
    /// Adds a product to the product catalog so that a user can search for it and it can be added to a cart, rented, purchased and shipped.
    /// </summary>
    [EndPoint("catalog/products/add", Name = "Add Product", Timeout = 5000, Version = 1)]
    public class AddProduct : EndPoint<AddProductCommand, string>
    {
        public override string Receive(AddProductCommand instance)
        {
            // TODO: add logic here

            // return the ID
            return "[Added Product ID]";
        }
    }
}
