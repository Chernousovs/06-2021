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
        public void FatherName_AddParentData_NamesAreEqual()
        {
            // Arrange
            Dog samDog = new Dog("Sam", "male");
            Dog ladyDog = new Dog("Lady", "female");
            Dog didiDog = new Dog("Didi", "female", ref ladyDog, ref samDog);

            //Act
            string didFatherName = didiDog.FatherName();
            string samFatherName = samDog.FatherName();

            // Assert
            Assert.AreEqual("Sam", didFatherName);
            Assert.AreEqual("Unknown", samFatherName);
        }

        [TestMethod]
        public void HasSameMotherAs__AddParentData_MothersAreEqual()
        {
            // Arrange
            Dog ladyDog = new Dog("Lady", "female");
            Dog maxDog = new Dog("Max", "male");
            Dog samDog = new Dog("Sam", "male", ref ladyDog, ref maxDog);
            Dog didiDog = new Dog("Didi", "female", ref ladyDog, ref maxDog);

            //Act
            bool isSameMotherAsMax = didiDog.HasSameMotherAs(samDog);
            bool isSameMotherAsDidi = samDog.HasSameMotherAs(didiDog);

            // Assert
            Assert.AreEqual(true, isSameMotherAsMax);
            Assert.AreEqual(true, isSameMotherAsDidi);
        }
    }
}