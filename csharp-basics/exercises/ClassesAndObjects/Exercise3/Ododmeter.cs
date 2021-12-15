using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Ododmeter
    {
        private const double MaxKilometers = 999999.0;
        private double _mileage;
        private int _traveledKilometers = 0;
        private FuelGauge _fuelGauge;

        public Ododmeter(double mileage, FuelGauge fuelGauge)
        {
            _mileage = mileage;
            _fuelGauge = fuelGauge;
        }

        public double CurrentMileage
        {
            get
            {
                return _mileage;
            }
        }

        public void IncrementCurrentMileage()
        {
            if (_fuelGauge.CurrentFuelAmount > 0)
            {
                OdometerCounterForFuelConsumption();
                if (_mileage <= MaxKilometers)
                {
                    _mileage++;
                }
                else
                {
                    _mileage = 0;
                }
            }

        }

        public void OdometerCounterForFuelConsumption()
        {
            _traveledKilometers++;
            if (_traveledKilometers == 10)
            {
                _fuelGauge.DecreaseAmountOFFuel();
                _traveledKilometers = 0;
            }
        }
        


    }
}
