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

            var beverageThree = new WhippedCream(new BigPortion(new HotChocolate()));
            Console.WriteLine(beverageThree.Description() + ": " + beverageThree.Cost());

            var beverageFour = new Marshmallow(new WhippedCream(new DoublePortion(new HotChocolate())));
            Console.WriteLine(beverageFour.Description() + ": " + beverageFour.Cost());

            Console.ReadKey();
        }
    }
}
