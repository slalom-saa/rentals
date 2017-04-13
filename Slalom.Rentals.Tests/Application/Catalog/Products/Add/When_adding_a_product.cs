using System;
using Slalom.Rentals.Application.Integration;
using Slalom.Rentals.Application.Products.Add;
using Slalom.Stacks.TestKit;
using Xunit;

namespace Slalom.Rentals.Tests.Application.Catalog.Products.Add
{
    public class StateZero : Scenario
    {
    }

    [TestSubject(typeof(AddProduct))]
    public class When_adding_a_product
    {
        [Fact]
        public void should_add_the_product_to_the_catalog()
        {
            using (var context = new TestStack())
            {
                context.UseEndPoint<SendNotification>();

                context.UseScenario(new StateZero().AsUser("emp@mail.com", "Employee"));

                context.Send(new AddProductCommand("name"));

                context.LastResult.ShouldBeSuccessful();
            }
        }

        [Fact]
        public void should_be_discoverable_in_search()
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

        [Fact]
        public void should_return_the_added_items_id()
        {
            // TODO: Implement test
            throw new NotImplementedException();
        }
    }
}