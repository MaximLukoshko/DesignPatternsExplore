using _04_FactoryMethod.Ingredients.Cheese;
using _04_FactoryMethod.Ingredients.Clam;
using _04_FactoryMethod.Ingredients.Dough;
using _04_FactoryMethod.Ingredients.Pepperoni;
using _04_FactoryMethod.Ingredients.Sauce;
using _04_FactoryMethod.Ingredients.Veggie;

namespace _04_FactoryMethod.Factories
{
    interface IAbstractIngredientsFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IPepperoni CreatePepperoni();
        IVeggie[] CreateVeggie();
        IClam CreateClam();
    }
}
