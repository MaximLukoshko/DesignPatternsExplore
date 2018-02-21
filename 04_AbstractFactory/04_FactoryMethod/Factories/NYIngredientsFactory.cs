using _04_FactoryMethod.Ingredients.Cheese;
using _04_FactoryMethod.Ingredients.Clam;
using _04_FactoryMethod.Ingredients.Dough;
using _04_FactoryMethod.Ingredients.Pepperoni;
using _04_FactoryMethod.Ingredients.Sauce;
using _04_FactoryMethod.Ingredients.Veggie;

namespace _04_FactoryMethod.Factories
{
    class NYIngredientsFactory : IAbstractIngredientsFactory
    {
        public IClam CreateClam() => new FreshClam();

        public ICheese CreateCheese() => new ReggianoCheese();

        public IDough CreateDough() => new ThinDough();

        public IPepperoni CreatePepperoni() => new SlicedPepperoni();

        public ISauce CreateSauce() => new MarinaraSauce();

        public IVeggie[] CreateVeggie() => new IVeggie[] { new Garlic(), new Onion(), new MushRoom() };
    }
}
