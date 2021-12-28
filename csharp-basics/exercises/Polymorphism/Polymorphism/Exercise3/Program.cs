using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(4.5);
            student1.SetNewFirstName("John");
            student1.SetNewLastName("Smith");
            student1.SetNewAddress("Baker street 221b");
            student1.Display();

            Employee employee = new Employee("Gardner");
            employee.SetNewFirstName("Sam");
            employee.SetNewLastName("Gamgee");
            employee.SetNewAddress("Bagshot Row");
            employee.Display();
        }
    }
}
