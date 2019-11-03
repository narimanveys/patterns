namespace AdapterPattern
{
    public class TurkeyDuckAdapter : ITurkey, IDuck
    {
        dynamic adaptee = null;

        void ITurkey.Gobble()
        {
            if (this.adaptee == null)
                this.adaptee = new Duck();

            adaptee.Quack();
        }

        void IDuck.Quack()
        {
            if (this.adaptee == null)
                this.adaptee = new Turkey();

            adaptee.Gobble();
        }

        void IDuck.Fly()
        {
            if (this.adaptee == null)
                this.adaptee = new Turkey();

            this.adaptee.Fly();
        }

        void ITurkey.Fly()
        {
            if (this.adaptee == null)
                this.adaptee = new Duck();

            this.adaptee.Fly();
        }
    }
}