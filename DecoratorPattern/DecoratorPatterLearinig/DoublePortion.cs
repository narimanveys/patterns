namespace DecoratorPatterLearinig
{
    public class DoublePortion : SizeDecorator
    {
        public DoublePortion(IBeverage beverage) : base(beverage)
        {
            _percent = 0.60;
            _prefix = "Double";
        }
    }
}