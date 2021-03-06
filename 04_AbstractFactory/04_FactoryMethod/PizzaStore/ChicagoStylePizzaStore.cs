﻿using _04_FactoryMethod.Factories;
using _04_FactoryMethod.Pizza;
using _04_FactoryMethod.Pizza.Chicago;

namespace _04_FactoryMethod.PizzaStore
{
    class ChicagoStylePizzaStore : PizzaStore
    {
        protected override AbstractPizza CreatePizza(PizzaTypesEn type)
        {
            var ingredientsFactory = new ChicagoIngredientsFactory();
            switch (type)
            {
                case PizzaTypesEn.Cheese:
                    return new CheesePizza(ingredientsFactory) { Name = "Chicago Style Cheese Pizza" };
                case PizzaTypesEn.Veggie:
                    return new VeggiePizza(ingredientsFactory) { Name = "Chicago Style Veggie Pizza" };
                case PizzaTypesEn.Clam:
                    return new ClamPizza(ingredientsFactory) { Name = "Chicago Style Clam Pizza" };
                case PizzaTypesEn.Pepperoni:
                    return new PepperoniPizza(ingredientsFactory) { Name = "Chicago Style Pepperoni Pizza" };
                default:
                    throw new System.NotImplementedException();
            }
        }
    }
}
