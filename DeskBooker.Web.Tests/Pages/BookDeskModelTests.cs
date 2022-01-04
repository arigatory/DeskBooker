using Xunit;
using DeskBooker.Core.Domain;
using DeskBooker.Core.Processor;
using Moq;

namespace DeskBooker.Web.Pages
{
    public class BookDeskModelTests
    {
        [Theory]
        [InlineData(1,true)]
        [InlineData(0,false)]
        public void ShouldCallDeskMethodOfProcessorIfModelIsValid(
            int expectedBookDeskCalls, bool isModelValid)
        {
            // Arrange 
            var processorMock = new Mock<IDeskBookingRequestProcessor>();

            var bookDeskModel = new BookDeskModel(processorMock.Object)
            {
                DeskBookingRequest = new DeskBookingRequest()
            };

            if (!isModelValid)
            {
                bookDeskModel.ModelState.AddModelError("JustAKey", "AnErrorMessage");
            }

            // Act 
            bookDeskModel.OnPost();


            // Assert
            processorMock.Verify(x => x.BookDesk(bookDeskModel.DeskBookingRequest), Times.Exactly(expectedBookDeskCalls));
        }



    }
}
