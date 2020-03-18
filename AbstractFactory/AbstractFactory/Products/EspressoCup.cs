namespace AbstractFactory.Products
{
    public class EspressoCup : ICup
    {
        public string GetCup()
        {
            return "Cup for espresso. ";
        }

        public string PutTogether(IBeverage beverage)
        {
            var result = beverage.GetBeverage();

            return $"Cup for espresso. with the ({result})";
        }
    }
}