namespace _03_Decorator.Beverage
{
    class Expresso : IBeverage
    {
        public int GetCost() => 79;
        public string GetDescription() => "Expresso";
    }
}
