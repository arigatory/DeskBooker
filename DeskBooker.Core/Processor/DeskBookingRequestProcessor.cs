using DeskBooker.Core.Domain;

namespace DeskBooker.Core.Processor
{
    public class DeskBookingRequestProcessor
    {
        public DeskBookingRequestProcessor()
        {
        }

        public DeskBookingResult BookDesk(DeskBookingRequest request)
        {
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