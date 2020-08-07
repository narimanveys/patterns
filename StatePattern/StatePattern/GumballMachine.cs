using System;

namespace StatePattern
{
    public class GumballMachine
    {
        public IState SoldOutState { get; set; }
        public IState NoQuarterState { get; set; }
        public IState HasQuarterState { get; set; }
        public IState SoldState { get; set; }

        public int CandyCount { get; private set; }
        public IState _state;
        public GumballMachine(int count)
        {
            SoldState = new SoldState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldOutState = new SoldOutState(this);
            
            CandyCount = count;
            if (CandyCount > 0)
            {
                _state = NoQuarterState;
            }
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes...");
            if (CandyCount != 0)
            {
                CandyCount--;
            }
        }

        // покупатель кладет монету в автомат
        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }
        // покупатель передумал и хочет забрать монету
        public void RemoveQuarter()
        {
            _state.GetCandy();
        }
        // покупатель поворачивает ручку автомата
        public void TurnCrank()
        {
            _state.TurnCrank();
        }
        // покупатель хочет забрать конфету
        public void GetCandy()
        {
            _state.GetCandy();
        }
    }
}