using _03_Decorator.Beverage;

namespace _03_Decorator.Decorators
{
    class Milk : IBeverageDecorator
    {
        private IBeverage Beverage { get; set; }

        public Milk(IBeverage beverage) => Beverage = beverage;

        public int GetCost() => 10 + Beverage.GetCost();

        public string GetDescription() => $"{Beverage.GetDescription()}, Milk";
    }
}
