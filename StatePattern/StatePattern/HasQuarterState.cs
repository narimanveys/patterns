using System;

namespace StatePattern
{
    public class HasQuarterState : IState
    {
        private GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
           Console.WriteLine("You can't insert another quarter.");
        }

        public void RemoveQuarter()
        {
            Console.WriteLine("Quarter returned.");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            _gumballMachine.SetState(_gumballMachine.SoldState);
        }

        public void GetCandy()
        {
            Console.WriteLine("Cant get gumball.");
        }
    }
}