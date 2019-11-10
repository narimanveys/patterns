namespace DecoratorPatterLearinig
{
    public abstract class CondimentDecorator : IBeverage
    {
        private IBeverage _beverage;

        protected string _name = "undefined";
        protected double _price = 0.0;

        protected CondimentDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string Description()
        {
            return $"{_beverage.Description()}, {_name}";
        }

        public double Cost()
        {
            return _beverage.Cost() + _price;
        }
    }
}