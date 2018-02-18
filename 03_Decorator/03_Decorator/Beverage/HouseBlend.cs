namespace _03_Decorator.Beverage
{
    class HouseBlend : IBeverage
    {
        public int GetCost() => 99;
        public string GetDescription() => "House Blend";
    }
}
