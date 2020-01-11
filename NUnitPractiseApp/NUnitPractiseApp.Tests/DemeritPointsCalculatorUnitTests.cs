using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace NUnitPractiseApp.Tests
{
    [TestFixture]
    public class DemeritPointsCalculatorUnitTests
    {

        /// <summary>
        /// If the speed of a car is over the speed limit, 
        /// return 1 demerit point for every 5 km over the speed limit.
        /// speed limit : 65
        /// max speed : 300
        /// i.e 
        /// speed : 69, speed limit =65; Return : 0 demerit points;
        /// speed : 70, speed limit =65; Return : 1 demerit points;
        /// 
        ///No penalty for going between 65 to 69 apparently...
        ///
        /// private const int SpeedLimit = 65;
        /// private const int MaxSpeed = 300;
        /// </summary>
        [Test]
        [TestCase(-1)]
        [TestCase(-10000)]
        [TestCase(10000)]
        public void CalculateDemeritPoints_InvalidInput_ReturnArugmentOutOfRangeException(int speed)
        {
            ///arange
            DemeritPointsCalculator dps = new DemeritPointsCalculator();

            ///assert
            Assert.That(() => dps.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        ///parametered tests
        
        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(20, 0)]
        [TestCase(69, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints (int speed, int expected)
        {
            ///arange
            DemeritPointsCalculator dps = new DemeritPointsCalculator();
            ///act
            var result = dps.CalculateDemeritPoints(speed);
            ///assert
            Assert.That(result, Is.EqualTo(expected));
        }
        #region old tests
        //[Test]
        //[TestCase(1)]
        //[TestCase(20)]
        //[TestCase(69)]
        //public void CalculateDemeritPoints_UnderSpeedLimit_Return0(int speed)
        //{
        //    ///arange
        //    DemeritPointsCalculator dps = new DemeritPointsCalculator();
        //    ///act
        //    var result = dps.CalculateDemeritPoints(speed);
        //    ///assert
        //    Assert.That(result, Is.EqualTo(0));
        //}

        //[Test]
        //public void CalculateDemeritPoints_OverSpeedLimit_ReturnCalculatedDemeritPoints()
        //{
        //    ///arange
        //    DemeritPointsCalculator dps = new DemeritPointsCalculator();
        //    ///expected
        //    int expected = 1;
        //    ///act
        //    var result = dps.CalculateDemeritPoints(70);
        //    ///assert
        //    Assert.That(result, Is.EqualTo(expected));
        //}

        #endregion


    }
}
