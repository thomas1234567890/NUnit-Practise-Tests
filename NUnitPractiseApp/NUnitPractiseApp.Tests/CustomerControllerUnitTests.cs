using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace NUnitPractiseApp.Tests
{
    [TestFixture]
    public class CustomerControllerUnitTests
    {
        /// Setup to reduce reused code
        private TestNinja.Fundamentals.CustomerController _customerController;

        [SetUp]
        ///make sure signiture is public
        public void Setup()
        {
            _customerController = new CustomerController();
        }

        [Test]
        public void GetCustomer__When_Id_Is_Zero__ReturnNotFound()
        {
            ///act
            var result = _customerController.GetCustomer(0);
            ///assert
            ///Type Of means it can be a NotFound object only.
            Assert.That(result, Is.TypeOf<NotFound>());
            ///Instance Of means it can be a NotFound object OR one of its derivitives
            ///Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void GetCustomer__When_Id_Is_Not_Zero__ReturnOK(int a)
        {
            ///act
            var result = _customerController.GetCustomer(a);
            ///assert
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
