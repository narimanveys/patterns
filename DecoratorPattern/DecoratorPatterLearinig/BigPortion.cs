namespace DecoratorPatterLearinig
{
    public class BigPortion : SizeDecorator
    {
        public BigPortion(IBeverage beverage) : base(beverage)
        {
            _prefix = "Big";
            _percent = 0.30;
        }
    }
}