using _04_FactoryMethod.Factories;
using static System.Console;

namespace _04_FactoryMethod.Pizza
{
    abstract class AbstractPizza
    {
        protected IAbstractIngredientsFactory IngredientsFactory { get; }

        protected string Name { get; set; }
        protected string Sauce { get; set; }
        protected string Dough { get; set; }
        protected string Pepperoni { get; set; }
        protected string Veggie { get; set; }
        protected string Calm { get; set; }

        protected AbstractPizza(IAbstractIngredientsFactory ingredientsFactory) =>
            IngredientsFactory = ingredientsFactory;

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
