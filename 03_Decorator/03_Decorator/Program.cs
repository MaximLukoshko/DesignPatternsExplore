using static System.Console;

using _03_Decorator.Beverage;
using _03_Decorator.Decorators;
using System.Collections.Generic;

namespace _03_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var beverages = new List<IBeverage> {
                new DarkRoast(),
                new Expresso(),
                new HouseBlend(),

                new Milk(new DarkRoast()),
                new Soya(new Expresso()),
                new Mocha(new Mocha( new HouseBlend())),

                new Milk(new Mocha(new Mocha(new Soya(new Expresso()))))
            };

            foreach(var b in beverages)
            {
                WriteLine(b.GetDescription());
                WriteLine($"Cost: ${b.GetCost()}");
                WriteLine();
            }
        }
    }
}
