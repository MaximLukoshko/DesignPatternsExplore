using _04_FactoryMethod.Pizza;
using _04_FactoryMethod.Pizza.New_York;

namespace _04_FactoryMethod.PizzaStore
{
    class NYStylePizzaStore : PizzaStore
    {
        protected override AbstractPizza CreatePizza(PizzaTypesEn type)
        {
            switch (type)
            {
                case PizzaTypesEn.Cheese:
                    return new NYCheesePizza();
                case PizzaTypesEn.Veggie:
                    return new NYVeggiePizza();
                case PizzaTypesEn.Clam:
                    return new NYClamPizza();
                case PizzaTypesEn.Pepperoni:
                    return new NYPepperoniPizza();
                default:
                    throw new System.NotImplementedException();
            }
        }
    }
}
