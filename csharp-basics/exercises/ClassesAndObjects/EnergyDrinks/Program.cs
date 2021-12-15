using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        
        private static void Main(string[] args)
        {
            EnergyDrinkSurveyAnalyzer energyDrinkSurveyAnalyzer = new EnergyDrinkSurveyAnalyzer(NumberedSurveyed);
            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine("Approximately " + energyDrinkSurveyAnalyzer.CalculateEnergyDrinkers() + " bought at least one energy drink");
            Console.WriteLine(energyDrinkSurveyAnalyzer.CalculatePreferCitrus() + " of those " + "prefer citrus flavored energy drinks.");
            Console.ReadKey();
        }
    }
}
