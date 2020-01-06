using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace NUnitPractiseApp.Tests
{
    [TestFixture]
    public class HtmlFormatterUnitTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseStringWithStrongElement()
        {
            ///arange
            var formater = new HtmlFormatter();
            ///act
            var result = formater.FormatAsBold("A to Z");
            ///assert

            ///specific
            //Assert.That(result, Is.EqualTo("<strong>A to Z</strong>"));
            /// below ignores case
            Assert.That(result, Is.EqualTo("<strong>A to Z</strong>").IgnoreCase);

            ///general
            //Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("A to Z"));
        }
    }
}
