using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook;

namespace Phonebook
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phonebook = new PhoneDirectory();

            Console.WriteLine("Adding new number in phoneBook");
            
            phonebook.PutNumber("John Smith", "+37128157178");
            phonebook.PutNumber("Geralt of Rivia", "+37129405694");
            phonebook.PutNumber("Johnny Silverhand", "+37128855599");
            phonebook.PutNumber("Peter Griffin", "+37125554422");
            phonebook.PutNumber("Thor Odinson", "+37127825963");

            Console.WriteLine("Write name:");
            String name = Console.ReadLine();
            Console.WriteLine($"{name} :  {phonebook.GetNumber(name)}\n");

            Console.ReadKey();
        }
    }
}
