using System;

namespace AdapterPattern
{
    public class Duck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Duck quacks");
        }

        public void Fly()
        {
            Console.WriteLine("Duck quacks");
        }
    }
}