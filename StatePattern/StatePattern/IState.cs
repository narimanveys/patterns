namespace StatePattern
{
    public interface IState
    {
        void InsertQuarter();
        void RemoveQuarter();
        void TurnCrank();
        void GetCandy();
    }
}