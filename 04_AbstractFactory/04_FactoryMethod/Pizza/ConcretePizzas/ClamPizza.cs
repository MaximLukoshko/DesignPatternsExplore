using _04_FactoryMethod.Factories;

namespace _04_FactoryMethod.Pizza.Chicago
{
    class ClamPizza : AbstractPizza
    {
        public ClamPizza(IAbstractIngredientsFactory ingredientsFactory) : base(ingredientsFactory)
        {
            Name = "Clam";
            Sauce = "Special Clam Sauce";
            Dough = IngredientsFactory.CreateCalm();
            Calm = IngredientsFactory.CreateCalm();
        }
    }
}
