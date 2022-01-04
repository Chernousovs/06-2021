using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class Exercise6ProgramTests
    {
        [TestMethod]
        public void FirstArray_ArrayOf10PositiveInts()
        {
            //Act
            int[] array1 = Program.FirstArray();

            //Assert
            Assert.AreEqual(0, array1.Count(o => o < 0));
        }

        [TestMethod]
        public void SecondArray_FirstArray_SecondShouldBeCopyOfFirst()
        {
            //Act
            int[] array1 = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] array2 = Program.SecondArray(array1);

            //Assert
            CollectionAssert.AreEqual(array2, array1);
        }

        [TestMethod]
        public void ChangeLast_FirstArray_LastElementOfFirstArrayIsChanged()
        {
            //Arrange
            int[] array1 = Program.FirstArray();

            //Act
            Program.ChangeLast(array1);
            int res = -7;

            //Assert
            Assert.AreEqual(array1[^1], res);
        }

        [TestMethod]
        public void WriteFirstArray_ChangedFirstArray_DisplayedArrayAsString()
        {
            //Arrange
            int[] array1 = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Program.ChangeLast(array1);

            //Act
            string result = Program.WriteFirstArray(array1);

            //Assert
            Assert.AreEqual(result, "Array1 : 1,2,3,4,5,6,7,8,9,-7");
        }

        [TestMethod]
        public void WriteSecondArray_SecondtArray_DisplayedArrayAsString()
        {
            //Arrange
            int[] array2 = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //Act
            string result = Program.WriteSecondArray(array2);

            //Assert
            Assert.AreEqual(result, "Array2 : 1,2,3,4,5,6,7,8,9,10");
        }
    }
}
