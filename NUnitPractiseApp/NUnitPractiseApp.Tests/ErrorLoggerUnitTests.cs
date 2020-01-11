using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace NUnitPractiseApp.Tests
{
    [TestFixture]
    public class ErrorLoggerUnitTests
    {

        ///setup
        private ErrorLogger _errorLogger;

        [SetUp]
        public void Setup()
        {
            _errorLogger = new ErrorLogger();
        }

        [Test]
        public void Log_VailidError_RaiseErrorLogEvent ()
        {
            ///arange
            var id = Guid.Empty;
            ///act
            _errorLogger.ErrorLogged+= (sender, args)=> { id = args; };
            _errorLogger.Log("a");
            ///assert
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
        [Test]
        [TestCase("This is an errrrorrrr.")]
        public void Log_WhenCalled_SetTheLastErrorProperty(string LoggedError)
        {
            ///act
            _errorLogger.Log(LoggedError);
            ///assert
            ///method is void so check the object it changes, the property LastError.
            Assert.That(_errorLogger.LastError, Is.EqualTo("This is an errrrorrrr."));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log__InvalidError__ThrowNewArgumentNullException(string error)
        {
            ///act
            /// We use delegates/lamda expressions to test for exceptions
            ///assert
            Assert.That(()=> _errorLogger.Log(error), Throws.ArgumentNullException);
            //Assert.That(()=> _errorLogger.Log(error), Throws.Exception.TypeOf<ArgumentNullException>());
        }
    }
}
