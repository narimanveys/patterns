namespace AbstractFactory.Products
{
    public class HotChocolate : IBeverage
    {
        public string GetBeverage()
        {
            return "The result of the product HotChocolate .";
        }
    }
}