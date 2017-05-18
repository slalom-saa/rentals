﻿using System;
using System.Collections.Generic;
using System.Text;
using Slalom.Stacks.Messaging.Validation;
using Slalom.Stacks.Validation;

namespace Slalom.Rentals.Application.Catalog.Rules
{
    /// <summary>
    /// Validates that the product name is unique.
    /// </summary>
    public class name_must_be_unique : BusinessRule<AddProductCommand>
    {
        /// <inheritdoc />
        public override ValidationError Validate(AddProductCommand instance)
        {
            
            // TODO: perform validation here
            return new ValidationError("NameNotUnique", "A product with the same name already exists.");
        }
    }
}