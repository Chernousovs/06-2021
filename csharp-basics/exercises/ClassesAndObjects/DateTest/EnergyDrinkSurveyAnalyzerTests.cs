using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnergyDrinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks.Tests
{
    [TestClass]
    public class EnergyDrinkSurveyAnalyzerTests
    {
        [TestMethod]
        public void CalculateEnergyDrinkersTest()
        {
            // Arrange
            EnergyDrinkSurveyAnalyzer energyDrinkSurveyAnalyzer = new EnergyDrinkSurveyAnalyzer(100);

            // Act
            double energyDrinkers = energyDrinkSurveyAnalyzer.CalculateEnergyDrinkers();

            // Assert
            Assert.AreEqual(14, energyDrinkers);
        }

        [TestMethod]
        public void CalculatePreferCitrusTest()
        {
            // Arrange
            EnergyDrinkSurveyAnalyzer energyDrinkSurveyAnalyzer = new EnergyDrinkSurveyAnalyzer(100);

            // Act
            double preferCitrus = energyDrinkSurveyAnalyzer.CalculatePreferCitrus();

            // Assert
            Assert.AreEqual(9, preferCitrus);
        }
    }
}