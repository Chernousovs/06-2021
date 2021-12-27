using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise5;

namespace DateTest
{
    [TestClass]
    public class Exercise4DateTest
    {
        private static StringWriter _stringWriter = new StringWriter();

        [TestMethod]
        public void DisplayDate_SetDate_Success()
        {
            // Arrange
            Console.SetOut(_stringWriter);
            int Month = 12;
            int Day = 25;
            int Year = 2021;
            Date date = new Date(Month, Day, Year);

            // Act
            date.DisplayDate();

            // Assert
            var output = _stringWriter.ToString();
            Assert.AreEqual("Date is 12 / 25 / 2021\r\n", output);
        }
    }
}
