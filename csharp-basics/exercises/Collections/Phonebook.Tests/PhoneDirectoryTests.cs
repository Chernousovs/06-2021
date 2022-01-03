using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneBook;

namespace Phonebook.Tests
{
    [TestClass]
    public class PhoneDirectoryTests
    {
        private PhoneDirectory _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new PhoneDirectory();
        }

        [TestMethod]
        public void PutNumber_Smith37128157178_ShouldContainSmith()
        {
            _target.PutNumber("Smith", "+37128157178");

            Assert.AreEqual("+37128157178", _target.GetNumber("Smith"));
        }

        [TestMethod]
        public void GetNumber_Smith_ShouldBeNull()
        {
            //Act
            var number = _target.GetNumber("Smith");

            //Assert
            Assert.AreEqual(null, number);
        }
    }
}
