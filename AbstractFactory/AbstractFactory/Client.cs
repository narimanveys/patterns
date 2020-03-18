using System;

namespace AbstractFactory
{
    public class Client
    {
        private ICup cup;
        private IBeverage beverage;
        public Client(IBeverageFactory factory)
        {
            cup = factory.CreateCup();
            beverage = factory.CreateBeverage();
        }
        public void Order()
        {
            cup.PutTogether(beverage);
            Console.WriteLine(cup.PutTogether(beverage));
        }
    }
}