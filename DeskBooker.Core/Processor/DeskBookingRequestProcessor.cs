using DeskBooker.Core.Domain;
using System;

namespace DeskBooker.Core.Processor
{
    public class DeskBookingRequestProcessor
    {
        public DeskBookingRequestProcessor()
        {
        }

        public DeskBookingResult BookDesk(DeskBookingRequest request)
        {
            if (request==null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return new DeskBookingResult
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Date = request.Date,
                Email = request.Email
            };
        }
    }
}