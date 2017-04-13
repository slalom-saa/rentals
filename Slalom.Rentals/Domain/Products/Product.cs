using System;
using System.Collections.Generic;
using System.Text;
using Slalom.Stacks.Domain;

namespace Slalom.Rentals.Domain.Products
{
    public class Product : AggregateRoot
    {
        public string Name { get; }

        public Product(string name)
        {
            this.Name = name;
        }

        public string Description { get; set; }
    }
}
