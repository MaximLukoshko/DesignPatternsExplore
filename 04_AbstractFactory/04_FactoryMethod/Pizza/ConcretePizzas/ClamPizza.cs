using static System.Console;
using _04_FactoryMethod.Factories;

namespace _04_FactoryMethod.Pizza.Chicago
{
    class ClamPizza : AbstractPizza
    {
        public ClamPizza(IAbstractIngredientsFactory ingredientsFactory) : base(ingredientsFactory) { }

        public override void Prepare()
        {
            WriteLine($"Preparing {Name}");
            Sauce = IngredientsFactory.CreateSauce();
            Dough = IngredientsFactory.CreateDough();
            Clam = IngredientsFactory.CreateClam();
            Cheese = IngredientsFactory.CreateCheese();
        }

        public override string ToString()
        {
            return $"Dough: {Dough.GetType().Name}\n" +
                $"Sauce: {Sauce.GetType().Name}\n" +
                $"Cheese: {Cheese.GetType().Name}\n" +
                $"Clam: {Clam.GetType().Name}\n";
        }
    }
}
