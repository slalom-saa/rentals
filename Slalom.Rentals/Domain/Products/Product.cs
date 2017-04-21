using System;
using System.Collections.Generic;
using System.Text;
using Slalom.Stacks.Domain;

namespace Slalom.Rentals.Domain.Products
{
    public class Product : AggregateRoot
    {
        public string Name { get; }
        public string Description { get; set; }

        public Product(string name, string description = null)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
