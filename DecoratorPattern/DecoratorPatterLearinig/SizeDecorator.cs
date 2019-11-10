namespace DecoratorPatterLearinig
{
    public abstract class SizeDecorator : IBeverage
    {
        private IBeverage _beverage;

        protected string _prefix = "undefined";
        protected double _percent = 0.0;

        protected SizeDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string Description()
        {
            return $"{_prefix} {_beverage.Description()} ";
        }

        public double Cost()
        {
            return _beverage.Cost() + _beverage.Cost() * _percent;
        }
    }
}