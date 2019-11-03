namespace AdapterPattern
{
    public class TurkeyAdapter : IDuck
    {
        public Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
           turkey.Gobble();
        }

        public void Quack()
        {
            turkey.Fly();
        }
    }
}