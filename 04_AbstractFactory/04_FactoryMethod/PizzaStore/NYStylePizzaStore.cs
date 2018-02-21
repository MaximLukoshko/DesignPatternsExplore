using _04_FactoryMethod.Factories;
using _04_FactoryMethod.Pizza;
using _04_FactoryMethod.Pizza.Chicago;

namespace _04_FactoryMethod.PizzaStore
{
    class NYStylePizzaStore : PizzaStore
    {
        protected override AbstractPizza CreatePizza(PizzaTypesEn type)
        {
            var ingredientsFactory = new NYIngredientsFactory();
            switch (type)
            {
                case PizzaTypesEn.Cheese:
                    return new CheesePizza(ingredientsFactory) { Name = "NY Style Cheese Pizza" };
                case PizzaTypesEn.Veggie:
                    return new VeggiePizza(ingredientsFactory) { Name = "NY Style Veggie Pizza" };
                case PizzaTypesEn.Clam:
                    return new ClamPizza(ingredientsFactory) { Name = "NY Style Clam Pizza" };
                case PizzaTypesEn.Pepperoni:
                    return new PepperoniPizza(ingredientsFactory) { Name = "NY Style Pepperoni Pizza" };
                default:
                    throw new System.NotImplementedException();
            }
        }
    }
}
