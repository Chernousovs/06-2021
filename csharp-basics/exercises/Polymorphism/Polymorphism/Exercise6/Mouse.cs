using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Mouse : Mammal
    {
        public Mouse(string animalType, string animalName,  double animalWeight, string livingRegion) 
            : base(animalName, animalType, animalWeight, livingRegion)
        {

        }

        public override void Eat(Food food)
        {
            if (!(food.GetType() == typeof(Vegetable)))
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
            Console.WriteLine("Mouse say: Oh, boy!");
        }

        public override string ToString()
        {
            return $"{GetAnimalType()} {GetAnimalName()} {GetAnimalWeight()} {GetLivingRegion()}";
        }
    }
}
