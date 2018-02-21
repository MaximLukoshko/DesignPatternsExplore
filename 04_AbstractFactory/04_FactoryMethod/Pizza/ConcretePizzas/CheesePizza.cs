using static System.Console;
using _04_FactoryMethod.Factories;

namespace _04_FactoryMethod.Pizza.Chicago
{
    class CheesePizza : AbstractPizza
    {
        public CheesePizza(IAbstractIngredientsFactory ingredientsFactory) : base(ingredientsFactory) { }

        public override void Prepare()
        {
            WriteLine($"Preparing {Name}");
            Cheese = IngredientsFactory.CreateCheese();
            Sauce = IngredientsFactory.CreateSauce();
            Dough = IngredientsFactory.CreateDough();
        }

        public override string ToString()
        {
            return $"Dough: {Dough.GetType().Name}\n" +
                $"Sauce: {Sauce.GetType().Name}\n" +
                $"Cheese: {Cheese.GetType().Name}\n";
        }
    }
}
