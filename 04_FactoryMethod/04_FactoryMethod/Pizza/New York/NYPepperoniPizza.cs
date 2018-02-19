using static System.Console;
namespace _04_FactoryMethod.Pizza.New_York
{
    class NYPepperoniPizza : AbstractPizza
    {
        public NYPepperoniPizza()
        {
            Name = "Pepperoni";
            Sauce = "Plum Tomato Sauce";
            Dough = "Extra Thick Crust Daugh";
        }

        public override void Cut()
        {
            WriteLine("Cutting into squares");
        }
    }
}
