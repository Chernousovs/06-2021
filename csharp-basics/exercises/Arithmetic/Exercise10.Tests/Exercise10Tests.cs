using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise10.Tests
{
    [TestClass]
    public class Exercise10Tests
    {
        [TestMethod]
        public void CircleArea_Radius_CircleArea()
        {
            //Arrange
            double radius = 5.5;

            //Act
            double areaResult = Geometry.CircleArea(radius);

            //Assert
            Assert.AreEqual(Math.Round(areaResult, 2), 95.03);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void CircleArea_RadiusAsNegativeNumber_GetInvalidDataExeptionBack()
        {
            //Arrange
            double radius = -5.5;

            //Act
            var areaResult = Geometry.CircleArea(radius);
        }

        [TestMethod]
        public void RectangleArea_RectangleLengthRectangleWidth_RectangleArea()
        {
            //Arrange
            double rectangleLength = 5.5;
            double rectangleWidth = 3.1;

            //Act
            double areaResult = Geometry.RectangleArea( rectangleLength,  rectangleWidth);

            //Assert
            Assert.AreEqual(Math.Round(areaResult, 2), 17.05);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void RectangleArea_RectangleLengthAsNegativeNumberRectangleWidth_GetInvalidDataExeptionBack()
        {
            //Arrange
            double rectangleLength = -5.5;
            double rectangleWidth = 3.1;

            //Act
            double areaResult = Geometry.RectangleArea( rectangleLength,  rectangleWidth);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void RectangleArea_RectangleLengthRectangleWidthAsNegativeNumber_GetInvalidDataExeptionBack()
        {
            //Arrange
            double rectangleLength = 5.5;
            double rectangleWidth = -3.1;

            //Act
            double areaResult = Geometry.RectangleArea( rectangleLength,  rectangleWidth);
        }

        [TestMethod]
        public void TriangleArea_TriangleBaseLengthTriangleHeight_TriangleArea()
        {
            //Arrange
            double trianleBaseLength = 5.5;
            double triangleHeight = 4.1;

            //Act
            double areaResult = Geometry.TriangleArea( trianleBaseLength,  triangleHeight);

            //Assert
            Assert.AreEqual(Math.Round(areaResult, 2), 11.27);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void TriangleArea_TriangleBaseLengthAsNegativeNumberTriangleHeight_GetInvalidDataExeptionBack()
        {
            //Arrange
            double trianleBaseLength = -5.5;
            double triangleHeight = 4.1;

            //Act
            double areaResult = Geometry.TriangleArea( trianleBaseLength,  triangleHeight);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void TriangleArea_TriangleBaseLengthTriangleHeightAsNegativeNumber_GetInvalidDataExeptionBack()
        {
            //Arrange
            double trianleBaseLength = 5.5;
            double triangleHeight = -4.1;

            //Act
            double areaResult = Geometry.TriangleArea( trianleBaseLength,  triangleHeight);
        }
    }
}
