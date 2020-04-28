using System;

namespace ChainOfResponsibility
{
    public class SupportHandler : AbstractHandler
    {
        public override Request Handle(Request request)
        {
            if (request.Specialization == "Support")
            {
                var handledRequest = new Request { Specialization = "Support", CreationDate = DateTime.UtcNow };
                return handledRequest;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}