using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{   
    [TestFixture]
    public class DemritPointsCalculatorTests
    {
        [Test]
        public void CalculateDemritPoints_SpeedGreaterThanSpeedLimit_ReturnDemritPoints()
        {
            var demritPoints = new DemeritPointsCalculator();

            var result = demritPoints.CalculateDemeritPoints(71);

            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void CalculateDemritPoints_SpeedGreaterThanSpeedLimitAndLessThan70_ReturnDemritPoints()
        {
            var demritPoints = new DemeritPointsCalculator();

            var result = demritPoints.CalculateDemeritPoints(67);

            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void CalculateDemritPoints_SpeedLessThanSpeedLimit_ReturnZero()
        {
            var demritPoints = new DemeritPointsCalculator();

            var result = demritPoints.CalculateDemeritPoints(60);

            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void CalculateDemritPoints_NegativeSpeedLimit_ThrowsException()
        {
            var demritPoints = new DemeritPointsCalculator();

            Assert.That(() => demritPoints.CalculateDemeritPoints(-65), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        public void CalculateDemritPoints_GreaterThanMaxSpeed_ThrowsException()
        {
            var demritPoints = new DemeritPointsCalculator();

            Assert.That(() => demritPoints.CalculateDemeritPoints(305), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
