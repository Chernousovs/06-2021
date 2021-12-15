using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class FuelGauge
    {
        private const double _fullTankCapacity = 70;
        private double _amountOfFuel;
        public FuelGauge(double amountOFFuel)
        {
            _amountOfFuel = amountOFFuel;
        }

        public double CurrentFuelAmount
        {
            get
            {
                return _amountOfFuel;
            }
        }

        public void IncreaseAmountOFFuel()
        {
            if (_amountOfFuel < _fullTankCapacity)
            {
                _amountOfFuel++;
            }
        }

        public void DecreaseAmountOFFuel()
        { 
            if (_amountOfFuel > 0)
            {
                _amountOfFuel--;
            }
        }

        public bool IsFull()
        {
            return _amountOfFuel == _fullTankCapacity;
        }
    }
}
