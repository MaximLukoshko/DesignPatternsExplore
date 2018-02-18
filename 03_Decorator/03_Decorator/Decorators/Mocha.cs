using _03_Decorator.Beverage;

namespace _03_Decorator.Decorators
{
    class Soya : IBeverageDecorator
    {
        private IBeverage Beverage { get; set; }

        public Soya(IBeverage beverage) => Beverage = beverage;

        public int GetCost() => 15 + Beverage.GetCost();

        public string GetDescription() => $"{Beverage.GetDescription()}, Soya";
    }
}
