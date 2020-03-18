namespace AbstractFactory
{
    public interface ICup
    {
        string GetCup();
        string PutTogether(IBeverage beverage);
    }
}