using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers, _endKilometers, _liters;

        public Car(double startOdo, double endingOdo, double liters)
        {
            _startKilometers = startOdo;
            _endKilometers = endingOdo;
            _liters = liters;
        }

        public double CalculateConsumption()
        { 
            return  _liters / (_endKilometers - _startKilometers);
        }

        private double ConsumptionPer100Km()
        {
            return CalculateConsumption() * 100;
        }

        public bool IsGasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool IsEconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            Console.WriteLine($"Next visit to gas station must be when Odometer shows {mileage + (liters / CalculateConsumption())}" );
        }
    }
}
