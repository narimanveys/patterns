using System;

namespace StatePattern
{
    public class SoldState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void RemoveQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");    
        }

        public void GetCandy()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.CandyCount > 0)
            {
                _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
        }
    }
}