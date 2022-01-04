using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Account.Tests
{
    [TestClass]
    public class AccountTests
    {
        private Account _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Account("Andersen", 10000.00);
        }

        [TestMethod]
        public void Withdrawal_Withdraw1000_ReturnBalance()
        {
            //Act
            _target.Withdrawal(1000.00);

            //Assert
            Assert.AreEqual(9000.00, _target.Balance());
        }

        [TestMethod]
        public void Deposit_AddToBalance1000_ReturnBalance()
        {
            //Act
            _target.Deposit(1000.00);

            //Assert
            Assert.AreEqual(11000.00, _target.Balance());
        }
    }
}
