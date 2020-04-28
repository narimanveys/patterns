using System;

namespace ChainOfResponsibility
{
    public class NewSubscriberHandler : AbstractHandler
    {
        public override Request Handle(Request request)
        {
            if (request.Specialization == "New")
            {
                var handledRequest = new Request {Specialization = "New", CreationDate = DateTime.UtcNow};
                return  handledRequest;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}