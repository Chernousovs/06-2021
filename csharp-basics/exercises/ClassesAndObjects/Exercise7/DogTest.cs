using System;
using System.ComponentModel.DataAnnotations;

namespace Exercise7
{
    class DogTest
    {
        static void Main(string[] args)
        {
            Dog sparkyDog = new Dog("Sparky", "male");
            Dog samDog = new Dog("Sam", "male");
            Dog ladyDog = new Dog("Lady", "female");
            Dog mollyDog = new Dog("Molly", "female");
            Dog rockyDog = new Dog("Rocky", "male", ref mollyDog, ref samDog);
            Dog maxDog = new Dog("Max", "male", ref ladyDog, ref rockyDog);
            Dog busterDog = new Dog("Buster", "male", ref ladyDog, ref sparkyDog);
            Dog cocoDog = new Dog("Coco", "female", ref mollyDog, ref busterDog);
            
            Console.WriteLine(cocoDog.FatherName());
            Console.WriteLine(sparkyDog.FatherName());

            Console.WriteLine(cocoDog.HasSameMotherAs(rockyDog));
            Console.WriteLine(busterDog.HasSameMotherAs(maxDog));
        }
    }
}
