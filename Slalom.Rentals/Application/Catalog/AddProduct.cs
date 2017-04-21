using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Slalom.Rentals.Application.Integration;
using Slalom.Rentals.Domain.Products;
using Slalom.Stacks.Messaging;
using Slalom.Stacks.Messaging.Exceptions;

namespace Slalom.Rentals.Application.Catalog
{
    /// <summary>
    /// Adds a product to the product catalog so that a user can search for it and it can be added to a cart, rented, purchased and shipped.
    /// </summary>
    [EndPoint("catalog/products/add", Name = "Add Product", Timeout = 5000, Version = 1)]
    public class AddProduct : EndPoint<AddProductCommand, string>
    {
        public override async Task<string> ReceiveAsync(AddProductCommand instance)
        {
            var target = new Product(instance.Name, instance.Description);

            await this.Domain.Add(target);

            var notify = this.Send(new SendNotification("email@email.com", "message"));
            if (notify.Result.IsSuccessful)
            {
                // rollbacko

                // throw new ChainFailedException(this.Request);
            }

            return target.Id;
        }
    }
}
