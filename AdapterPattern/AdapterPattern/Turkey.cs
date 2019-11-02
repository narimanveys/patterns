using System;

namespace AdapterPattern
{
    public class Turkey:ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Turkey is gobbling");
        }

        public void Fly()
        {
            Console.WriteLine("Turkey flies");
        }
    }
}