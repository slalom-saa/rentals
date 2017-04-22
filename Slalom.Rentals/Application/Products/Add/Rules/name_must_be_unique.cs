using System.Threading.Tasks;
using Slalom.Rentals.Domain.Products;
using Slalom.Stacks.Services.Validation;
using Slalom.Stacks.Validation;

namespace Slalom.Rentals.Application.Products.Add.Rules
{
    /// <summary>
    /// Validates that the product name is unique.
    /// </summary>
    public class name_must_be_unique : BusinessRule<AddProductCommand>
    {
        public override async Task<ValidationError> ValidateAsync(AddProductCommand instance)
        {
            if (await this.Domain.Exists<Product>(e => e.Name == instance.Name))
            {
                return new ValidationError("NameNotUnique", "A product with the same name already exists.");
            }
            return null;
        }
    }
}
