using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CozaLozaWoza.Tests
{
    [TestClass]
    public class CozaLozaWozaTests
    {
        [TestMethod]
        public void CheckNumber_IndexEquals3_StringCoza()
        {
            //Arrange
            int index = 3;

            //Act
            string result = Program.CheckNumber(index);

            //Assert
            Assert.AreEqual(result, "Coza");
        }

        [TestMethod]
        public void CheckNumber_IndexEquals5_StringWoza()
        {
            //Arrange
            int index = 5;

            //Act
            string result = Program.CheckNumber(index);

            //Assert
            Assert.AreEqual(result, "Woza");
        }

        [TestMethod]
        public void CheckNumber_IndexEquals15_StringCozaWoza()
        {
            //Arrange
            int index = 30;

            //Act
            string result = Program.CheckNumber(index);

            //Assert
            Assert.AreEqual(result, "CozaWoza");
        }

        [TestMethod]
        public void CheckNumber_IndexEquals2_StringIndex()
        {
            //Arrange
            int index = 2;

            //Act
            string result = Program.CheckNumber(index);

            //Assert
            Assert.AreEqual(result, "2");
        }
    }
}
