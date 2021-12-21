using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoStore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore.Tests
{
    [TestClass]
    public class VideoStoreTests
    {
        [TestMethod]
        public void ListInventory_SetTitles_ReturnsListOfTitles()
        {
            // Arrange
            VideoStore videoStore = new VideoStore();

            var title1 = "The Matrix";
            var title2 = "Godfather II";
            var title3 = "Star Wars Episode IV: A New Hope";

            videoStore.AddVideo(title1);
            videoStore.AddVideo(title2);
            videoStore.AddVideo(title3);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            videoStore.ListInventory();

            // Assert
            var output = stringWriter.ToString();
            Assert.AreEqual(
                $"{title1} | Average rating: 0 | Available NOW\r\n" +
                $"{title2} | Average rating: 0 | Available NOW\r\n" +
                $"{title3} | Average rating: 0 | Available NOW\r\n", output);
        }

        [TestMethod]
        public void Checkout_ListOfTitles_ReturnCheckedOutTitles()
        {
            // Arrange
            VideoStore videoStore = new VideoStore();

            List<string> listOfTitles = new List<string>();

            listOfTitles.Add("The Matrix");
            listOfTitles.Add("Godfather II");
            listOfTitles.Add("Star Wars Episode IV: A New Hope");
            
            foreach (var title in listOfTitles)
            {
                videoStore.AddVideo(title);
            }

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            videoStore.Checkout("The Matrix");
            videoStore.Checkout("Star Wars Episode IV: A New Hope");

            // Assert
            videoStore.ListInventory();
            var output = stringWriter.ToString();
            Assert.AreEqual(
                "The Matrix | Average rating: 0 | Unavailable\r\n" +
                "Godfather II | Average rating: 0 | Available NOW\r\n" +
                "Star Wars Episode IV: A New Hope | Average rating: 0 | Unavailable\r\n", output);
        }

        [TestMethod]
        public void ReturnVideo_ListOfTitles_Return_ReturnedTitles()
        {
            // Arrange
            VideoStore videoStore = new VideoStore();

            List<string> listOfTitles = new List<string>();

            listOfTitles.Add("The Matrix");
            listOfTitles.Add("Godfather II");
            listOfTitles.Add("Star Wars Episode IV: A New Hope");
            
            foreach (var title in listOfTitles)
            {
                videoStore.AddVideo(title);
            }

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            videoStore.Checkout("The Matrix");
            videoStore.Checkout("Star Wars Episode IV: A New Hope");

            videoStore.ReturnVideo("The Matrix");
            videoStore.ReturnVideo("Star Wars Episode IV: A New Hope");

            // Assert
            videoStore.ListInventory();
            var output = stringWriter.ToString();
            Assert.AreEqual(
                "The Matrix | Average rating: 0 | Available NOW\r\n" +
                "Godfather II | Average rating: 0 | Available NOW\r\n" +
                "Star Wars Episode IV: A New Hope | Average rating: 0 | Available NOW\r\n", output);
        }

        [TestMethod]
        public void TakeUsersRating_ListOfTitles_Return_UsersRating()
        {
            // Arrange
            VideoStore videoStore = new VideoStore();

            List<string> listOfTitles = new List<string>();

            listOfTitles.Add("The Matrix");
            listOfTitles.Add("Godfather II");
            listOfTitles.Add("Star Wars Episode IV: A New Hope");
            
            foreach (var title in listOfTitles)
            {
                videoStore.AddVideo(title);
            }

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            videoStore.TakeUsersRating(5, "The Matrix");
            videoStore.TakeUsersRating(4, "Godfather II");

            // Assert
            videoStore.ListInventory();
            var output = stringWriter.ToString();
            Assert.AreEqual(
                "The Matrix | Average rating: 5 | Available NOW\r\n" +
                "Godfather II | Average rating: 4 | Available NOW\r\n" +
                "Star Wars Episode IV: A New Hope | Average rating: 0 | Available NOW\r\n", output);
        }
    }
}