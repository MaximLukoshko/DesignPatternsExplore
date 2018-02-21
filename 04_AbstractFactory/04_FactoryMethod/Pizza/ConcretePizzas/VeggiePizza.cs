using _04_FactoryMethod.Factories;
using System.Linq;
using static System.Console;

namespace _04_FactoryMethod.Pizza.Chicago
{
    class VeggiePizza : AbstractPizza
    {
        public VeggiePizza(IAbstractIngredientsFactory ingredientsFactory) : base(ingredientsFactory) { }

        public override void Box()
        {
            WriteLine("Boxing into green veggie box...");
        }

        public override void Prepare()
        {
            WriteLine($"Preparing {Name}");
            Sauce = IngredientsFactory.CreateSauce();
            Dough = IngredientsFactory.CreateDough();
            Cheese = IngredientsFactory.CreateCheese();
            Veggies = IngredientsFactory.CreateVeggie();
        }

        public override string ToString()
        {
            return $"Dough: {Dough.GetType().Name}\n" +
                $"Sauce: {Sauce.GetType().Name}\n" +
                $"Cheese: {Cheese.GetType().Name}\n" +
                $"Veggies: {string.Join(", ", Veggies.Select(n => n.GetType().Name).ToArray())}\n";
        }
    }
}
