using _03_Decorator.Beverage;

namespace _03_Decorator.Decorators
{
    class Mocha : IBeverageDecorator
    {
        private IBeverage Beverage { get; set; }

        public Mocha(IBeverage beverage) => Beverage = beverage;

        public int GetCost() => 20 + Beverage.GetCost();

        public string GetDescription() => $"{Beverage.GetDescription()}, Mocha";
    }
}
