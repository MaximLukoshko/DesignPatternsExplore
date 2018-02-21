using _04_FactoryMethod.Factories;
using _04_FactoryMethod.Ingredients.Cheese;
using _04_FactoryMethod.Ingredients.Clam;
using _04_FactoryMethod.Ingredients.Dough;
using _04_FactoryMethod.Ingredients.Pepperoni;
using _04_FactoryMethod.Ingredients.Sauce;
using _04_FactoryMethod.Ingredients.Veggie;
using static System.Console;

namespace _04_FactoryMethod.Pizza
{
    abstract class AbstractPizza
    {
        protected IAbstractIngredientsFactory IngredientsFactory { get; }

        public string Name { get; set; }
        protected ISauce Sauce { get; set; }
        protected IDough Dough { get; set; }
        protected IPepperoni Pepperoni { get; set; }
        protected IVeggie[] Veggies { get; set; }
        protected IClam Clam { get; set; }
        protected ICheese Cheese { get; set; }

        protected AbstractPizza(IAbstractIngredientsFactory ingredientsFactory) =>
            IngredientsFactory = ingredientsFactory;

        public abstract void Prepare();

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
