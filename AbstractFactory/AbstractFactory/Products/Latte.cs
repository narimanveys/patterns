namespace AbstractFactory.Products
{
    public class Latte: IBeverage
    {
        public string GetBeverage()
        {
            return "The result of the product Latte .";
        }
    }
}