using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*both sides*/
            ITurkey turkey = new TurkeyDuckAdapter();
            turkey.Fly();
            turkey.Gobble();

            /*Turkey to duck*/

            Turkey turkeyy = new Turkey();

            IDuck turkeyAdapter = new TurkeyAdapter(turkeyy);
            Console.WriteLine("----------------------------------");
            turkeyAdapter.Fly();
            turkeyAdapter.Quack();
            Console.ReadKey();
        }
    }
}
