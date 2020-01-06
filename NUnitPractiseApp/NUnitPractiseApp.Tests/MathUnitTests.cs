using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitPractiseApp.Tests
{

    [TestFixture]
    public class MathUnitTests
    {
        ///setup
        private TestNinja.Fundamentals.Math _math;

        [SetUp]
        public void Setup()
        {
            _math = new TestNinja.Fundamentals.Math();
        }

        /// <summary>
        /// Nameing convention for test
        /// public void MethodName_Condition_ExpectedResult () {}
        /// </summary>
        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            ///act
            var result = _math.Add(1, 2);
            ///assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        /// max returns the larger number
        public void Max_FirstNumberIsGreater_ReturnFirstNumber()
        {
            ///act
            var result = _math.Max(2, 1);
            ///assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondNumberIsGreater_ReturnSecondNumber()
        {
            ///act
            var result = _math.Max(1, 2);
            ///assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_NumbersAreTheSame_ReturnSameNumber()
        {
            ///act
            var result = _math.Max(3, 3);
            ///assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void GetOddNumbers_WhenCalled_ReturnAllOddNumbers()
        {
            ///arrange
            List<int> expected = new List<int> { 1, 3 };
            
            ///act
            var result = _math.GetOddNumbers(4);
            
            ///assert
            CollectionAssert.AreEqual(result, expected);
        }

        [Test]
        public void GetEvenNumbers_WhenCalled_ReturnAllEven()
        {
            ///arange
            List<int> expected = new List<int> { 2,4};
            ///act 
            var result = _math.GetEvenNumbers(4);
            ///arange
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Subtract_WhenCalled_SubtractArgumentTwoFromOne()
        {
            ///act
            var result = _math.Subtract(2, 1);
            ///assert
            Assert.That(result, Is.EqualTo(1));
        }

    }
}
