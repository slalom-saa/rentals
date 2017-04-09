using Slalom.Rentals.Application.Catalog.Products.Add;
using Slalom.Stacks;
using Slalom.Stacks.Text;
using System;

namespace Slalom.Rentals.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stack = new Stack(typeof(AddProduct)))
            {
                stack.Send(new AddProductCommand("name")).Result.OutputToJson();
            }   
        }
    }
}