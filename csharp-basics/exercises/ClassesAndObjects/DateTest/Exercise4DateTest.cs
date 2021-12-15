using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise5;

namespace DateTest
{
    [TestClass]
    public class Exercise4DateTest
    {
        [TestMethod]
        public void DateTest()
        {
            // Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            int Month = 12;
            int Day = 25;
            int Year = 2021;
            Date date = new Date(Month, Day, Year);

            // Act
            date.DisplayDate();

            // Assert
            var output = stringWriter.ToString();
            Assert.AreEqual("Date is 12 / 25 / 2021\r\n", output);
        }
    }
}
