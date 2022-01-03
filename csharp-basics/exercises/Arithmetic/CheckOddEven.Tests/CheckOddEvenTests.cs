using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckOddEven.Tests
{
    [TestClass]
    public class CheckOddEvenTests
    {
        [TestMethod]
        public void CheckOddOrEven_EvenNumber_StringNumberIsEven()
        {
            //Arrange
            int enteredNumber = 2;

            //Act
            string result = Program.CheckOddOrEven(enteredNumber);

            //Assert
            Assert.AreEqual(result, "2 is Even Number");
        }

        [TestMethod]
        public void CheckOddOrEven_OddNumber_StringNumberIsOdd()
        {
            //Arrange
            int enteredNumber = 3;

            //Act
            string result = Program.CheckOddOrEven(enteredNumber);

            //Assert
            Assert.AreEqual(result, "3 is Odd Number");
        }
    }
}
