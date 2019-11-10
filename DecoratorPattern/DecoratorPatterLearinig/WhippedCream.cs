namespace DecoratorPatterLearinig
{
    public class WhippedCream : CondimentDecorator
    {
        public WhippedCream(IBeverage beverage) : base(beverage)
        {
            _name = "with Whipped Cream";
            _price = 30;
        }
    }
}