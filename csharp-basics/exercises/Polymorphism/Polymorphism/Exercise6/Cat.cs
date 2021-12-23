using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Cat : Felines
    {
        private string _breed;
        public Cat(string animalType, string animalName, string breed, double animalWeight, string livingRegion) 
            : base(animalName, animalType, animalWeight, livingRegion)
        {
            _breed = breed;
        }

        public override void Eat(Food food)
        {
            if (!(food.GetType() == typeof(Meat)))
            {
                Console.WriteLine($"{GetAnimalType()} are not eating that type of food!");
            }
            else
            {
                Console.WriteLine(food.ToString());
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cat say: Meowwww");
        }

        public override string ToString()
        {
            return $"{GetAnimalType()} {GetAnimalName()} {GetAnimalWeight()} {GetLivingRegion()} {_breed}";
        }
    }
}
