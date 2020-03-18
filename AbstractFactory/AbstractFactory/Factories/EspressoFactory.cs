using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class EspressoFactory : IBeverageFactory
    {
        public ICup CreateCup()
        {
            return new EspressoCup();
        }

        public IBeverage CreateBeverage()
        {
            return new Espresso();
        }
    }
}