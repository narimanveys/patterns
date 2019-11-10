using System;

namespace DecoratorPatterLearinig
{
    class Program
    {
        static void Main(string[] args)
        {
            var beverageOne = new Marshmallow(new WhippedCream(new Espresso()));
            Console.WriteLine(beverageOne.Description() +": " + beverageOne.Cost());

            var beverageTwo = new WhippedCream(new HotChocolate());
            Console.WriteLine(beverageTwo.Description() + ": " + beverageTwo.Cost());
            Console.ReadKey();
        }
    }
}
