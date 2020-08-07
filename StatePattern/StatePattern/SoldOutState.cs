using System;

namespace StatePattern
{
    public class SoldOutState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the gumballs sold out");
        }

        public void RemoveQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter yet, so you can't get it back");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public void GetCandy()
        {
            Console.WriteLine("Gumball machine is sold out, you can't get candy");
        }
    }
}