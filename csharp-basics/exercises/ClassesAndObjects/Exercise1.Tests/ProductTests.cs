using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class ProductTests
    {
        private Product _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Product("Name", 9.99, 100);
        }

        [TestMethod]
        public void ChangePrice_Price_NewPrice()
        {
            _target.ChangePrice(20.55);

            //Assert
            Assert.AreEqual(20.55, _target.Price);
        }

        [TestMethod]
        public void ChangeQuantity_Amount_NewAmount()
        {
            _target.ChangeQuantity(50);

            //Assert
            Assert.AreEqual(50, _target.Amount);
        }
    }
}
