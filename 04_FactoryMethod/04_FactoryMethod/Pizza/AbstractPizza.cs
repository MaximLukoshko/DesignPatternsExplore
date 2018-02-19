using static System.Console;

namespace _04_FactoryMethod.Pizza
{
    abstract class AbstractPizza
    {
        protected string Name { get; set; }
        protected string Sauce { get; set; }
        protected string Dough { get; set; }

        public void Prepare()
        {
            WriteLine($"Name: {Name}");
            WriteLine($"Sauce: {Sauce}");
            WriteLine($"Dough: {Dough}");
        }

        public virtual void Bake()
        {
            WriteLine("Baking Pizza...");
        }

        public virtual void Cut()
        {
            WriteLine("Cutting Diagonal...");
        }

        public virtual void Box()
        {
            WriteLine("Boxing into default PizzaStore box...");
        }
    }
}
