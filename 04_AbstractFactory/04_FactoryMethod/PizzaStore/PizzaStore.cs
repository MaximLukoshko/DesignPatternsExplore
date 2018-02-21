using _04_FactoryMethod.Pizza;
using static System.Console;

namespace _04_FactoryMethod.PizzaStore
{
    abstract class PizzaStore
    {
        public void OrderPizza(PizzaTypesEn type)
        {
            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            WriteLine();
            WriteLine(pizza);
        }

        protected abstract AbstractPizza CreatePizza(PizzaTypesEn type);
    }
}
