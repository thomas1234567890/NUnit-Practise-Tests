using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace NUnitPractiseApp.Tests
{
    [TestFixture]
    public class FizzBuzzUnitTests
    {
        /// <summary>
        /// Fizz Buzz example
        /// When the user enters a number return a word based on wheather 
        /// the number is divisible by 3 and or 5.
        /// OR
        /// If the number is not divisible by 3 or 5, return the number as a string.
        /// i.e
        /// number entered : 2;     Return : "2";
        /// number entered : 3;     Return : "Fizz";
        /// number entered : 5;     Return : "Buzz";
        /// number entered : 10;    Return : "Buzz";
        /// number entered : 30;   Return : "FizzBuzz";
        /// </summary>

        [Test]
        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void GetOutput_NumberDividedBy3And5_ReturnFizzBuzz(int number)
        {
            ///act 
            var result = FizzBuzz.GetOutput(number);
            //var result = fizzbuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void GetOutput_NumberDividedBy3AndNot5_ReturnFizz( int number)
        {
            ///act 
            var result = FizzBuzz.GetOutput(number);
            
            ///assert
            Assert.That(result, Is.EqualTo("Fizz"));

        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void GetOutput_NumberDividedBy5AndNot3_ReturnBuzz(int number)
        {
            ///act
            var result = FizzBuzz.GetOutput(number);

            ///assert
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(8)]
        [TestCase(11)]
        public void GetOutput_NumberCannotBeDividedBy3Or5_ReturnNumberAsString(int number)
        {
            ///act
            var result = FizzBuzz.GetOutput(number);

            ///assert
            Assert.That(result, Is.EqualTo(number.ToString()));
        }

    }
}
