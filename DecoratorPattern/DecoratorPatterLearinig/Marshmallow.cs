namespace DecoratorPatterLearinig
{
    public class Marshmallow : CondimentDecorator
    {
        public Marshmallow(IBeverage beverage) : base(beverage)
        {
            _name = "with Marshmallow";
            _price = 35;
        }
    }
}