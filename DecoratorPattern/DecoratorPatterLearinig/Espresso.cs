namespace DecoratorPatterLearinig
{
    public class Espresso : IBeverage
    {
        /*private bool _bigBeverage;
        private bool _doubleBeverage;
        private bool _whippedCream;
        private bool _marshmallow;

        public Espresso(bool bigBeverage, bool doubleBeverage, bool whippedCream, bool marshmallow)
        {
            _bigBeverage = bigBeverage;
            _doubleBeverage = doubleBeverage;
            _whippedCream = whippedCream;
            _marshmallow = marshmallow;
        }*/

        public string Description()
        {
            return "Espresso";
        }

        public double Cost()
        {
            return 50;
        }
    }
}