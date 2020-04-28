using System;

namespace ChainOfResponsibility
{
    public class SubscriberDepartmentHandler : AbstractHandler
    {
        public override Request Handle(Request request)
        {
            if (request.Specialization == "Subscriber")
            {
                var handledRequest = new Request { Specialization = "Subscriber", CreationDate = DateTime.UtcNow };
                return handledRequest;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}