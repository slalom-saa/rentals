using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using Slalom.Rentals.Application.Catalog;
using Slalom.Rentals.Application.Integration;
using Slalom.Rentals.Domain.Products;
using Slalom.Stacks.TestKit;
using Xunit;

namespace Slalom.Rentals.Tests.Application.Products
{
    [TestSubject(typeof(AddProduct))]
    public class When_adding_a_product
    {
        [Fact]
        public void should_add_the_product_to_the_catalog()
        {
            using (var stack = new TestStack(typeof(AddProduct)))
            {
                stack.UseEndPoint<SendNotification>();

                stack.Send(new AddProductCommand("name", "description"));

                var target = stack.Domain.Find<Product>().Result.FirstOrDefault();

                target.Should().NotBeNull();
            }
        }

        [Fact]
        public void should_be_discoverable_in_search()
        {
            // TODO: Implement test
            throw new NotImplementedException();
        }

        [Fact]
        public void should_return_the_added_items_id()
        {
            // TODO: Implement test
            throw new NotImplementedException();
        }

        [Fact]
        public void should_raise_the_event()
        {
            // TODO: Implement test
            throw new NotImplementedException();
        }
    }
}
