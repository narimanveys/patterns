namespace AbstractFactory.Products
{
    public class LatteCup : ICup
    {
        public string GetCup()
        {
            return "Cup for Latte";
        }

        public string PutTogether(IBeverage beverage)
        {
            var result = beverage.GetBeverage();

            return $"Cup for Latte with the {result}";
        }
    }
}