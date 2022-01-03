using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class Exercise6Tests
    {
        private Animal _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new Mouse("Mouse", "Mikey", 0.121, "Livingroom");
        }

        [TestMethod]
        public void GetAnimalName_AnimalName()
        {
            //Act
            _target.GetAnimalName();

            //Assert
            Assert.AreEqual("Mikey", _target.GetAnimalName());
        }

        [TestMethod]
        public void GetAnimalType_AnimalType()
        {
            //Act
            _target.GetAnimalType();

            //Assert
            Assert.AreEqual("Mouse", _target.GetAnimalType());
        }

        [TestMethod]
        public void GetAnimalWigth_AnimalWeight()
        {
            //Act
            _target.GetAnimalWeight();

            //Assert
            Assert.AreEqual(0.121, _target.GetAnimalWeight());
        }
    }
}
