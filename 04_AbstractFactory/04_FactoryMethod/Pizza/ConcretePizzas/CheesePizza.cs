using _04_FactoryMethod.Factories;

namespace _04_FactoryMethod.Pizza.Chicago
{
    class CheesePizza : AbstractPizza
    {
        public CheesePizza(IAbstractIngredientsFactory ingredientsFactory) : base(ingredientsFactory)
        {
            Name = "Cheese";
            Sauce = IngredientsFactory.CreateMarinaraSauce();
            Dough = IngredientsFactory.CreateDough();
        }
    }
}
