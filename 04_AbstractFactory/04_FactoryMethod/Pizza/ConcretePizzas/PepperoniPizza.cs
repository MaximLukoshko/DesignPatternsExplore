using static System.Console;
using _04_FactoryMethod.Factories;

namespace _04_FactoryMethod.Pizza.Chicago
{
    class PepperoniPizza : AbstractPizza
    {
        public PepperoniPizza(IAbstractIngredientsFactory ingredientsFactory) : base(ingredientsFactory) { }

        public override void Prepare()
        {
            WriteLine($"Preparing {Name}");
            Cheese = IngredientsFactory.CreateCheese();
            Sauce = IngredientsFactory.CreateSauce();
            Dough = IngredientsFactory.CreateDough();
            Pepperoni = IngredientsFactory.CreatePepperoni();
        }

        public override string ToString()
        {
            return $"Dough: {Dough.GetType().Name}\n" +
                $"Sauce: {Sauce.GetType().Name}\n" +
                $"Cheese: {Cheese.GetType().Name}\n" +
                $"Pepperoni: {Pepperoni.GetType().Name}\n";
        }
    }
}
