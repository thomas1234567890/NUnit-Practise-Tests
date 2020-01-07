using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace NUnitPractiseApp.Tests
{
    [TestFixture]
    public class CustomerControllerUnitTests
    {
        [Test]
        public void GetCustomer__When_Id_Is_Zero__ReturnNotFound()
        {
            ///arange
            var customerController = new CustomerController();
            ///act
            var result = customerController.GetCustomer(0);
            ///assert
            ///Type Of means it can be a NotFound object only.
            Assert.That(result, Is.TypeOf<NotFound>());
            ///Instance Of means it can be a NotFound object OR one of its derivitives
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer__When_Id_Is_Not_Zero__ReturnOK()
        {
            ///arange
            var customerController = new CustomerController();
            ///act
            var result = customerController.GetCustomer(1);
            ///assert
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
