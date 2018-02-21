using _04_FactoryMethod.Pizza;
using _04_FactoryMethod.Pizza.Chicago;

namespace _04_FactoryMethod.PizzaStore
{
    class ChicagoStylePizzaStore : PizzaStore
    {
        protected override AbstractPizza CreatePizza(PizzaTypesEn type)
        {
            switch (type)
            {
                case PizzaTypesEn.Cheese:
                    return new ChicagoCheesePizza();
                case PizzaTypesEn.Veggie:
                    return new ChicagoVeggiePizza();
                case PizzaTypesEn.Clam:
                    return new ChicagoClamPizza();
                case PizzaTypesEn.Pepperoni:
                    return new ChicagoPepperoniPizza();
                default:
                    throw new System.NotImplementedException();
            }
        }
    }
}
