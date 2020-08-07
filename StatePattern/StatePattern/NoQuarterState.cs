using System;

namespace StatePattern
{
    public class NoQuarterState : IState
    {
        private GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _gumballMachine.SetState(_gumballMachine.HasQuarterState);
        }

        public void RemoveQuarter()
        {
            Console.WriteLine("You don't inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("There is no quarter");
        }

        public void GetCandy()
        {
            Console.WriteLine("Need to pay");
        }
    }
}