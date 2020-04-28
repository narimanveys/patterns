using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            var possibleRequests = new List<Request> { new Request{Specialization = "New"}, new Request{Specialization = "Subscriber"}, new Request(){Specialization = "Support"}};
            foreach (var departments in possibleRequests)
            {
                Console.WriteLine($"Client: Who wants a {departments.Specialization}?");

                var result = handler.Handle(departments);

                if (result != null)
                {
                    Console.Write($"Result:   {result.Specialization}");
                }
                else
                {
                    Console.WriteLine($"   {departments.Specialization} was left untouched.");
                }
            }
        }
    }
}