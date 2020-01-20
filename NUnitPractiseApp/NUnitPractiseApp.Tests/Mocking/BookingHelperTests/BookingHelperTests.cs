using NUnit.Framework;
using TestNinja.Mocking;

namespace NUnitPractiseApp.Tests.Mocking.BookingHelperTests
{
    [TestFixture]
    class BookingHelperTests
    {
        [Test]
        public void OverlappingBookingsExist_BookingStatusCancelled_ReturnStringEmpty ()
        {
            ///arange
            var booking = new Booking { Status = "Cancelled" };
            string expected = string.Empty;
            ///act
            var result = BookingHelper.OverlappingBookingsExist(new FakeUnitOfWork(), booking );
            ///assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
