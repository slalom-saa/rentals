using Slalom.Stacks.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slalom.Rentals.Application.Catalog.Products.Add
{
    public class AddProductCommand
    {
        /// <summary>
        /// Gets the name of the product to add.
        /// </summary>
        /// <value>The name of the product to add.</value>
        [NotNull("Name must be specified.")]
        public string Name { get; }

        public AddProductCommand(string name)
        {
            this.Name = name;
        }
    }
}
