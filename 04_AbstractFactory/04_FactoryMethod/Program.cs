using static System.Console;

using _04_FactoryMethod.Pizza;
using _04_FactoryMethod.PizzaStore;

namespace _04_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicagoPizzaStore = new ChicagoStylePizzaStore();
            var newYorkPizzaStore = new NYStylePizzaStore();

            WriteLine("Chicago pizza ordered");
            chicagoPizzaStore.OrderPizza(PizzaTypesEn.Cheese);
            WriteLine();
            WriteLine();

            WriteLine("NY pizza ordered");
            newYorkPizzaStore.OrderPizza(PizzaTypesEn.Cheese);
            WriteLine();
            WriteLine();

            WriteLine("Chicago pizza ordered");
            chicagoPizzaStore.OrderPizza(PizzaTypesEn.Clam);
            WriteLine();
            WriteLine();

            WriteLine("NY pizza ordered");
            newYorkPizzaStore.OrderPizza(PizzaTypesEn.Clam);
            WriteLine();
            WriteLine();

            WriteLine("Chicago pizza ordered");
            chicagoPizzaStore.OrderPizza(PizzaTypesEn.Veggie);
            WriteLine();
            WriteLine();

            WriteLine("NY pizza ordered");
            newYorkPizzaStore.OrderPizza(PizzaTypesEn.Veggie);
            WriteLine();
            WriteLine();

            WriteLine("Chicago pizza ordered");
            chicagoPizzaStore.OrderPizza(PizzaTypesEn.Pepperoni);
            WriteLine();
            WriteLine();

            WriteLine("NY pizza ordered");
            newYorkPizzaStore.OrderPizza(PizzaTypesEn.Pepperoni);
            WriteLine();
            WriteLine();
        }
    }
}
