using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;
            client = new Client(new LatteFactory());
            client.Order();
            Console.ReadKey();
        }
    }
}
