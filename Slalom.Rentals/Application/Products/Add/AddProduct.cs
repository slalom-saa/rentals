using System.Threading.Tasks;
using Slalom.Rentals.Application.Integration;
using Slalom.Rentals.Domain.Products;
using Slalom.Stacks.Services;

namespace Slalom.Rentals.Application.Products.Add
{
    /// <summary>
    /// Adds a product to the product catalog so that a user can search for it and it can be added to a cart, rented, purchased and shipped.
    /// </summary>
    [EndPoint("catalog/products/add", Name = "Add Product", Timeout = 5000, Version = 1)]
    public class AddProduct : EndPoint<AddProductCommand, string>
    {
        public override async Task<string> ReceiveAsync(AddProductCommand instance)
        {
            var product = new Product(instance.Name);
            await this.Domain.Add(product);

            var result = await this.Send(new SendNotification("send@email.com", "Your request has been"));
            if (!result.IsSuccessful)
            {
            }

            // return the ID
            return "[Added Product ID]";
        }
    }
}
