using static System.Console;

namespace _04_FactoryMethod.Pizza.Chicago
{
    class ChicagoVeggiePizza : AbstractPizza
    {
        public ChicagoVeggiePizza()
        {
            Name = "Veggie";
            Sauce = "Veggie Sauce";
            Dough = "Thin Crust Daugh";
        }

        public override void Box()
        {
            WriteLine("Boxing into green veggie box...");
        }
    }
}
