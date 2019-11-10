namespace DecoratorPatterLearinig
{
    public class HotChocolate : IBeverage
    {
        public string Description()
        {
            return "HotChocolate";
        }

        public double Cost()
        {
            return 100;
        }
    }
}