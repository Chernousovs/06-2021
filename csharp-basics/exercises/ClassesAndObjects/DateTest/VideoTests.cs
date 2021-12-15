using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore.Tests
{
    [TestClass()]
    public class VideoTests
    {
        [TestMethod]
        public void AverageRatingTest()
        {
            // Arrange
            Video newVideo = new Video("Star Wars Episode IV: A New Hope");

            // Act
            double output = newVideo.AverageRating();

            // Assert
            Assert.AreEqual(0, output);
        }

        [TestMethod]
        public void AverageRatingTest_ReceivingRating()
        {
            // Arrange
            Video newVideo = new Video("Star Wars Episode IV: A New Hope");
            newVideo.ReceivingRating(5);
            newVideo.ReceivingRating(4);
            newVideo.ReceivingRating(3);

            // Act
            double output = newVideo.AverageRating();

            // Assert
            Assert.AreEqual(4, output);
        }

        [TestMethod]
        public void AvailableTest()
        {
            // Arrange
            Video newVideo = new Video("Star Wars Episode IV: A New Hope");

            // Act
            bool output = newVideo.Available();

            // Assert
            Assert.AreEqual(true, output);
        }

        [TestMethod]
        public void AvailableTest_BeingCheckedOut()
        {
            // Arrange
            Video newVideo = new Video("Star Wars Episode IV: A New Hope");
            newVideo.BeingCheckedOut();

            // Act
            bool output = newVideo.Available();

            // Assert
            Assert.AreEqual(false, output);
        }

        [TestMethod]
        public void AvailableTest_BeingReturned()
        {
            // Arrange
            Video newVideo = new Video("Star Wars Episode IV: A New Hope");
            newVideo.BeingCheckedOut();
            newVideo.BeingReturned();

            // Act
            bool output = newVideo.Available();

            // Assert
            Assert.AreEqual(true, output);
        }

        [TestMethod]
        public void ToStringTest()
        {
            // Arrange
            Video newVideo = new Video("Star Wars Episode IV: A New Hope");

            // Act
            string output = newVideo.ToString();

            // Assert
            Assert.AreEqual("Star Wars Episode IV: A New Hope | Average rating: 0 | Available NOW", output);
        }
    }
}