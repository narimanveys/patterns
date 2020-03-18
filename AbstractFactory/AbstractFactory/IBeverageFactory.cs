namespace AbstractFactory
{
    public interface IBeverageFactory
    {
        ICup CreateCup();
        IBeverage CreateBeverage();
    }
}