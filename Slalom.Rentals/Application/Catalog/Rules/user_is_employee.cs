using System;
using System.Collections.Generic;
using System.Text;
using Slalom.Stacks.Messaging.Validation;
using Slalom.Stacks.Validation;

namespace Slalom.Rentals.Application.Catalog.Rules
{
    /// <summary>
    /// Validates that a user is registered.
    /// </summary>
    public class user_is_employee : SecurityRule<AddProductCommand>
    {
        /// <inheritdoc />
        public override ValidationError Validate(AddProductCommand instance)
        {
            // TODO: perform validation here
            return new ValidationError("UserNotEmployee", "You must be an employee to add a product.");
        }
    }
}
