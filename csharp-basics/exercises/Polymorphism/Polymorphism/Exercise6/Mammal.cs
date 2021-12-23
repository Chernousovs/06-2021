using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public abstract class Mammal : Animal
    {
        public string _livingRegion;

        public Mammal(string animalName, string animalType, double animalWeight, string livingRegion) 
            : base(animalName, animalType, animalWeight)
        {
            _livingRegion = livingRegion;
        }

        public string GetLivingRegion()
        {
            return _livingRegion;
        }
    }
}
