using Xunit;
using DeskBooker.Core.Domain;
using DeskBooker.Core.Processor;
using Moq;

namespace DeskBooker.Web.Pages
{
    public class BookDeskModelTests
    {
        [Fact]
        public void ShouldCallDeskMethodOfProcessor()
        {
            // Arrange 
            var processorMock = new Mock<IDeskBookingRequestProcessor>();

            var bookDeskModel = new BookDeskModel(processorMock.Object)
            {
                DeskBookingRequest = new DeskBookingRequest()
            };


            // Act 
            bookDeskModel.OnPost();


            // Assert
            processorMock.Verify(x => x.BookDesk(bookDeskModel.DeskBookingRequest), Times.Once);
        }



    }
}
