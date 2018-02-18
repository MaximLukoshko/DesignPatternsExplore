namespace _03_Decorator.Beverage
{
    class DarkRoast : IBeverage
    {
        public int GetCost() => 119;
        public string GetDescription() => "Dark Roast";
    }
}
