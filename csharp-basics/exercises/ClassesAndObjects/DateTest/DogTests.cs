using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7.Tests
{
    [TestClass]
    public class DogTests
    {
        [TestMethod]
        public void FatherNameTest()
        {
            // Arrange
            Dog didiDog = new Dog("Didi", "female");
            Dog samDog = new Dog("Sam", "male");
            Dog ladyDog = new Dog("Lady", "female");

            //Act
            didiDog.AddParentData(ref ladyDog, ref samDog);
            string didFatherName = didiDog.FatherName();
            string samFatherName = samDog.FatherName();

            // Assert
            Assert.AreEqual("Sam", didFatherName);
            Assert.AreEqual("Unknown", samFatherName);
        }

        [TestMethod]
        public void HasSameMotherAsTest()
        {
            // Arrange
            Dog didiDog = new Dog("Didi", "female");
            Dog samDog = new Dog("Sam", "male");
            Dog ladyDog = new Dog("Lady", "female");
            Dog maxDog = new Dog("Max", "male");

            //Act
            didiDog.AddParentData(ref ladyDog, ref samDog);
            maxDog.AddParentData(ref ladyDog, ref samDog);
            bool isSameMotherAsMax = didiDog.HasSameMotherAs(maxDog);
            bool isSameMotherAsDidi = maxDog.HasSameMotherAs(didiDog);

            // Assert
            Assert.AreEqual(true, isSameMotherAsMax);
            Assert.AreEqual(true, isSameMotherAsDidi);
        }
    }
}