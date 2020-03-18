namespace AbstractFactory.Products
{
    public class HotChocolateCup : ICup 
    {
        public string GetCup()
        {
            return "Cup for HotChocolate";
        }

        public string PutTogether(IBeverage beverage)
        {
            var result = beverage.GetBeverage();
            
            return $"Cup for Hot Chocolate with the ({result})";
        }
    }
}