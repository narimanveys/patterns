namespace ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        Request Handle(Request request);
    }
}