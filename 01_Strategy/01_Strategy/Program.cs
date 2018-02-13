using _01_Strategy.Behaviour;
using _01_Strategy.Ducks;
using System;
using System.Collections.Generic;

namespace _01_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var ducks = new List<Duck>{
            new MallardDuck(),
            new RedHeadDuck(),
            new GumDuck(),
            new WoodenDuck(),
            new RocketDuck(),
            new SteelDuck()
        };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformQuack();
                duck.PerformFly();
                duck.PerformSwim();

                Console.WriteLine();
                //Console.WriteLine($"var name is {nameof(duck)}");

                duck.FlyBehaviour = new NoFlyBehaviour();
                duck.QuackBehaviour = new SilentBehaviour();
                duck.SwimBehaviour = new NoSwimBehaviour();
            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformQuack();
                duck.PerformFly();
                duck.PerformSwim();
                Console.WriteLine();
            }
        }
    }
}
