using Slalom.Rentals.Application.Catalog;
using Slalom.Stacks;
using Slalom.Stacks.Web.AspNetCore;

namespace Slalom.Rentals.ConsoleHost
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var stack = new Stack(typeof(AddProduct)))
            {
                stack.RunWebHost();
            }

        }
    }
}