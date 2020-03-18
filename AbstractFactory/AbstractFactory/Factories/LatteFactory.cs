using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class LatteFactory : IBeverageFactory
    {
        public ICup CreateCup()
        {
            return new LatteCup();
        }

        public IBeverage CreateBeverage()
        {
            return new Latte();
        }
    }
}