using Slalom.Stacks.Messaging.Validation;
using Slalom.Stacks.Validation;

namespace Slalom.Rentals.Application.Products.Add.Rules
{
    /// <summary>
    /// Validates that a user is registered.
    /// </summary>
    public class user_is_employee : SecurityRule<AddProductCommand>
    {
        /// <inheritdoc />
        public override ValidationError Validate(AddProductCommand instance)
        {
            if (!this.Request.User.IsInRole("Employee"))
            {
                return new ValidationError("UserNotEmployee", "You must be an employee to add a product.");
            }
            return null;
        }
    }
}
