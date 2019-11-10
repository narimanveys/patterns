namespace DecoratorPatterLearinig
{
    public class Latte : IBeverage
    {
        public string Description()
        {
            return "Latte";
        }

        public double Cost()
        {
            return 80;
        }
    }
}