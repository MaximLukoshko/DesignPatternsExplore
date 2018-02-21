namespace _04_FactoryMethod.Factories
{
    interface IAbstractIngredientsFactory
    {
        string CreateMarinaraSauce();
        string CreateDough();
        string CreatePepperoni();
        string CreateVeggie();
        string CreateCalm();
    }
}
