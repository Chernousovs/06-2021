using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise8.Tests
{
    [TestClass]
    public class Exercise8tests
    {
        [TestMethod]
        public void TotalPay_ValuesForEquation_RetrunsTotalSalary()
        {
            //Arrange
            double basePay = 8.50;
            int hoursWorked = 45;

            //Act
            decimal reslut = Program.TotalPay((decimal)basePay, hoursWorked);

            //Assert
            Assert.AreEqual(reslut, (decimal)403.75);
        }

        [TestMethod]
        public void DisplayTotalSalary_TotalPay_ReturnStringAnswer()
        {
            //Arrange
            double basepay = 8.50;
            int hoursWorked = 45;
            string errorMessage = "Error, check input data";

            //Act
            string result = Program.DisplayTotalSalary(hoursWorked, (decimal)basepay, errorMessage);

            //Assert
            Assert.AreEqual(result, "Employee's total Salary: 403.75");
        }

        [TestMethod]
        public void DisplayTotalSalary_TotalPay_ReturnErrorMessage()
        {
            //Arrange
            double basepay = 7.50;
            int hoursWorked = 45;
            string errorMessage = "Error, check input data";

            //Act
            string result = Program.DisplayTotalSalary(hoursWorked, (decimal)basepay, errorMessage);

            //Assert
            Assert.AreEqual(result, "Error, check input data");
        }
    }
}
