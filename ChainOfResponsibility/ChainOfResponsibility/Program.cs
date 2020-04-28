using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var support = new SupportHandler();
            var newSubscriber = new NewSubscriberHandler();
            var subscriber = new SubscriberDepartmentHandler();

            newSubscriber.SetNext(support).SetNext(subscriber);

            Console.WriteLine("Chain: newSubscriber > support > subscriber\n");
            Client.ClientCode(newSubscriber);
            Console.WriteLine();

            Console.WriteLine("Subchain: support > subscriber\n");
            Client.ClientCode(support);

            Console.ReadKey();
        }
    }
}
