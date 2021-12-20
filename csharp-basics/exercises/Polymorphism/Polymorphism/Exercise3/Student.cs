using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Student : Person
    {
        public Student(double gpa)
        {
            Gpa = gpa;
        }

        public double Gpa { get; }

        public override void Display()
        {
            Console.WriteLine($"\tStudent information\n" +
                              $"First name\t: {FirstName} \n" +
                              $"Last name\t: {LastName} \n" +
                              $"Address\t: {Address} \n" +
                              $"Students GPA\t: {Gpa}");
        }
    }
}
