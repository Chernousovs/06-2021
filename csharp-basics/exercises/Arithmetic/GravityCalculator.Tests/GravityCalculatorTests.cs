using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GravityCalculator.Tests
{
    [TestClass]
    public class GravityCalculatorTests
    {
        [TestMethod]
        public void FinalPositionCalc_ValuesOfEquation()
        {
            //Arrange
            double gravity = -9.81;
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;

            //Act
            double result = Program.FinalPositionCalc(gravity, fallingTime, initialVelocity, initialPosition);

            //Assert
            Assert.AreEqual(result, -490.5);
        }
    }
}