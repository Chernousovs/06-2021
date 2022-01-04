using Microsoft.VisualStudio.TestTools.UnitTesting;
using DragRace;

namespace DragRace.Tests
{
    [TestClass]
    public class DragRaceTests
    {
        private ICar _target;

        [TestMethod]
        public void SpeedUp_Plus15_AudiCurrentSpeed15()
        {
            //Arrange
            _target = new Audi();

            //Act
            _target.SpeedUp();
            var res = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("15", res);
        }

        [TestMethod]
        public void SlowDown_Minus15_AudiCurrentSpeed15()
        {
            //Arrange
            _target = new Audi();

            //Act
            _target.SpeedUp();
            _target.SlowDown();
            var res = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("0", res);
        }

        [TestMethod]
        public void SpeedUp_BmwCurrentSpeed15()
        {
            //Arrange
            _target = new Bmw();

            //Act
            _target.SpeedUp();
            var res = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("20", res);
        }

        [TestMethod]
        public void SlowDown_BmwCurrentSpeed15()
        {
            //Arrange
            _target = new Bmw();

            //Act
            _target.SpeedUp();
            _target.SlowDown();
            var res = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("0", res);
        }

        [TestMethod]
        public void SpeedUp_LexusCurrentSpeed15()
        {
            //Arrange
            _target = new Lexus();

            //Act
            _target.SpeedUp();
            var res = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("10", res);
        }

        [TestMethod]
        public void SlowDown_LexusCurrentSpeed15()
        {
            //Arrange
            _target = new Lexus();

            //Act
            _target.SpeedUp();
            _target.SlowDown();
            var res = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("0", res);
        }

        [TestMethod]
        public void SpeedUp_TeslaCurrentSpeed15()
        {
            //Arrange
            _target = new Tesla();

            //Act
            _target.SpeedUp();
            var res = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("30", res);
        }

        [TestMethod]
        public void SlowDown_TeslaCurrentSpeed15()
        {
            //Arrange
            _target = new Tesla();

            //Act
            _target.SpeedUp();
            _target.SlowDown();
            var res = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("0", res);
        }

        [TestMethod]
        public void UseNitrousOxideEngine_LexusCurrentSpeed30()
        {
            //Arrange
            var targetCar = new Lexus();

            //Act
            targetCar.UseNitrousOxideEngine();
            var res = targetCar.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("30", res);
        }

        [TestMethod]
        public void UseNitrousOxideEngine_PeugeotCurrentSpeed30()
        {
            //Arrange
            var targetCar = new Peugeot();

            //Act
            targetCar.UseNitrousOxideEngine();
            var res = targetCar.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual("30", res);
        }
    }
}
