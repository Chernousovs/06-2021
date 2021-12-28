using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Employee : Person
    {
        public Employee(string jobTitle)
        {
            JobTitle = jobTitle;
        }

        public string JobTitle { get; private set; }

        public void SetNewJobTitle(string newJobTitle)
        {
            JobTitle = newJobTitle;
        }

        public override void Display()
        {
            Console.WriteLine($"\tEmployee's information\n" +
                              $"First name\t: {FirstName} \n" +
                              $"Last name\t: {LastName} \n" +
                              $"Address\t: {Address} \n" +
                              $"Job title\t: {JobTitle}");
        }
    }
}
