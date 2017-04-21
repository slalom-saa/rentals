using System;
using System.Collections.Generic;
using System.Text;
using Slalom.Stacks.Validation;

namespace Slalom.Rentals.Application.Catalog
{
    public class AddProductCommand
    {
        /// <summary>
        /// Gets the name of the product to add.
        /// </summary>
        /// <value>The name of the product to add.</value>
        [NotNull("Name must be specified.")]
        public string Name { get; }

        /// <value>An optional description for the product.</value>
        public string Description { get; }

        public AddProductCommand(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
