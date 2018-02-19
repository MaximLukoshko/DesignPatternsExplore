using static System.Console;
namespace _04_FactoryMethod.Pizza.New_York
{
    class NYCheesePizza : AbstractPizza
    {
        public NYCheesePizza()
        {
            Name = "Cheese";
            Sauce = "Plum Tomato Sauce";
            Dough = "Extra Thick Crust Daugh";
        }

        public override void Cut()
        {
            WriteLine("Cutting into squares");
        }

        public override void Box()
        {
            WriteLine("Boxing into mice with cheese colored box...");
        }
    }
}
