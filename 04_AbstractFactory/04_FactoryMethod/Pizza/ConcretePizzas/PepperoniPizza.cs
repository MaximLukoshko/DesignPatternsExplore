using _04_FactoryMethod.Factories;

namespace _04_FactoryMethod.Pizza.Chicago
{
    class PepperoniPizza : AbstractPizza
    {
        public PepperoniPizza(IAbstractIngredientsFactory ingredientsFactory) : base(ingredientsFactory)
        {
            Name = "Pepperoni";
            Sauce = "Hot spicy Sauce";
            Dough = IngredientsFactory.CreateDough();
            Pepperoni = IngredientsFactory.CreatePepperoni();
        }
    }
}
