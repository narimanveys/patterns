namespace AbstractFactory.Products
{
    public class Espresso : IBeverage
    {
        public string GetBeverage()
        {
            return "The result of the product Espresso.";
        }
    }
}