using Slalom.Stacks;
using Slalom.Stacks.Text;
using System;
using Slalom.Rentals.Application.Products.Add;
using Slalom.Stacks.Web.AspNetCore;

namespace Slalom.Rentals.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stack = new Stack(typeof(AddProduct)))
            {
                stack.RunWebHost();
            }   
        }
    }
}