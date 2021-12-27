using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    public class EnergyDrinkSurveyAnalyzer
    {
        private readonly int _numberSurveyed;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        public EnergyDrinkSurveyAnalyzer(int numberSurveyed)
        {
            _numberSurveyed = numberSurveyed;
        }
        public double CalculateEnergyDrinkers()
        {
            return Math.Round(_numberSurveyed * PurchasedEnergyDrinks);
        }

        public double CalculatePreferCitrus()
        {
            return Math.Round(CalculateEnergyDrinkers() * PreferCitrusDrinks);
        }
    }
}
