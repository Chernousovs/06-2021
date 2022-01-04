using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightPlanner.Tests
{
    [TestClass]
    public class FlightPlannerTests
    {
        [TestMethod]
        public void FindPossibleDestinations_CityToStartAndListToAdd_List()
        {
            //Arrange
            string cityToStart = "New York";
            List<string> flightDestinationsList = new List<string>();
            
            
            //Act
            List<string> listResult = Program.FindPossibleDestinations(cityToStart, flightDestinationsList);

            //Assert
            CollectionAssert.AreEqual(listResult, new List<string>());
        }

        [TestMethod]
        public void HasReachedLastDestination_FullDictionaryFlightHistory_ReturnTrue()
        {
            //Arrange
            Dictionary<int, string> flightHistory = new Dictionary<int, string>();
            flightHistory.Add(1, "New York");
            flightHistory.Add(2, "San Francisco");
            flightHistory.Add(3, "New York");

            //Act
            bool result = Program.HasReachedLastDestination(flightHistory);

            //Arrange
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void HasReachedLastDestination_DictionaryFlightHistory_ReturnFalse()
        {
            //Arrange
            Dictionary<int, string> flightHistory = new Dictionary<int, string>();
            flightHistory.Add(1, "New York");
            flightHistory.Add(2, "San Francisco");

            //Act
            bool result = Program.HasReachedLastDestination(flightHistory);

            //Arrange
            Assert.AreEqual(result, false);
        }
    }
}
