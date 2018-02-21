using _04_FactoryMethod.Ingredients.Cheese;
using _04_FactoryMethod.Ingredients.Clam;
using _04_FactoryMethod.Ingredients.Dough;
using _04_FactoryMethod.Ingredients.Pepperoni;
using _04_FactoryMethod.Ingredients.Sauce;
using _04_FactoryMethod.Ingredients.Veggie;

namespace _04_FactoryMethod.Factories
{
    class ChicagoIngredientsFactory : IAbstractIngredientsFactory
    {
        public IClam CreateClam() => new FrozenClam();

        public ICheese CreateCheese() => new Mozzarella();

        public IDough CreateDough() => new ThickDough();

        public IPepperoni CreatePepperoni() => new SlicedPepperoni();

        public ISauce CreateSauce() => new PlumTomatoSauce();

        public IVeggie[] CreateVeggie() => new IVeggie[] { new Spinach(), new BlackOlives(), new EggPlant() };
    }
}
