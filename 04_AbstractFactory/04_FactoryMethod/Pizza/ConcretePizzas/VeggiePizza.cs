using _04_FactoryMethod.Factories;
using static System.Console;

namespace _04_FactoryMethod.Pizza.Chicago
{
    class VeggiePizza : AbstractPizza
    {
        public VeggiePizza(IAbstractIngredientsFactory ingredientsFactory) : base(ingredientsFactory)
        {
            Name = "Veggie";
            Sauce = "Veggie Sauce";
            Dough = IngredientsFactory.CreateDough();
            Veggie = IngredientsFactory.CreateVeggie();
        }

        public override void Box()
        {
            WriteLine("Boxing into green veggie box...");
        }
    }
}
