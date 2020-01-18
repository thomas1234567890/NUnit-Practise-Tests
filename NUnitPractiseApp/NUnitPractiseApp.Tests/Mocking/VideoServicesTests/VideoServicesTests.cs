using NUnit.Framework;
using NUnitPractiseApp.Tests.VideoServicesTests;
using TestNinja.Mocking;

namespace NUnitPractiseApp.Tests.Mocking.VideoServices
{
    [TestFixture]
    class VideoServicesTests
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_Return ()
        {
            ///arange
            var service = new VideoService();
            ///act
            var result = service.ReadVideoTitle(new FakeFileReader(), "");
            ///assert
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
