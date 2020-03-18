using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class HotChocolateFactory : IBeverageFactory
    {
        public ICup CreateCup()
        {
            return new HotChocolateCup();
        }

        public IBeverage CreateBeverage()
        {
            return new HotChocolate();
        }
    }
}