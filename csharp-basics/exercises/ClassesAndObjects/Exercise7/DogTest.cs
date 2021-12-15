using System;
using System.ComponentModel.DataAnnotations;

namespace Exercise7
{
    class DogTest
    {
        static void Main(string[] args)
        {
            Dog maxDog = new Dog("Max", "male");
            Dog rockyDog = new Dog("Rocky", "male");
            Dog sparkyDog = new Dog("Sparky", "male");
            Dog busterDog = new Dog("Buster", "male");
            Dog samDog = new Dog("Sam", "male");
            Dog ladyDog = new Dog("Lady", "female");
            Dog mollyDog = new Dog("Molly", "female");
            Dog cocoDog = new Dog("Coco", "female");

            maxDog.AddParentData(ref ladyDog, ref rockyDog);
            cocoDog.AddParentData(ref mollyDog, ref busterDog);
            rockyDog.AddParentData(ref mollyDog, ref samDog);
            busterDog.AddParentData(ref ladyDog, ref sparkyDog);
           
            Console.WriteLine(cocoDog.FatherName());
            Console.WriteLine(sparkyDog.FatherName());

            Console.WriteLine(cocoDog.HasSameMotherAs(rockyDog));
            Console.WriteLine(busterDog.HasSameMotherAs(maxDog));
        }
    }
}
