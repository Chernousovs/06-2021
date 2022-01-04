using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class Exercise1Tests
    {
        [TestMethod]
        public void CheckFor15_FirstNumberEqual15_True()
        {
            //Arrange
            int firstNumber = 15;
            int secondNumber = 1;

            //Act
            bool result = Program.CheckFor15(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void CheckFor15_SecondNumberEqual15_True()
        {
            //Arrange
            int firstNumber = 1;
            int secondNumber = 15;

            //Act
            bool result = Program.CheckFor15(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void CheckFor15_TwoNumberSumEqual15_True()
        {
            //Arrange
            int firstNumber = 10;
            int secondNumber = 5;

            //Act
            bool result = Program.CheckFor15(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void CheckFor15_TwoNumberDifferenceEqual15_True()
        {
            //Arrange
            int firstNumber = 45;
            int secondNumber = 30;

            //Act
            bool result = Program.CheckFor15(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void CheckFor15_FirstNumberNotEqual15_False()
        {
            //Arrange
            int firstNumber = 10;
            int secondNumber = 1;

            //Act
            bool result = Program.CheckFor15(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(result, false);
        }
    }
}
