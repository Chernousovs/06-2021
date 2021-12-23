using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public abstract class Animal
    {
        private string _animalName, _animalType;
        private double _animalWeight;
        private int _foodEaten;

        protected Animal(string animalName, string animalType, double animalWeight)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeight = animalWeight;
        }

        public string GetAnimalName()
        {
            return _animalName;
        }

        public string GetAnimalType()
        {
            return _animalType;
        }

        public double GetAnimalWeight()
        {
            return _animalWeight;
        }

        public abstract void MakeSound();

        public abstract void Eat(Food food);

        public abstract string ToString();
    }
}
