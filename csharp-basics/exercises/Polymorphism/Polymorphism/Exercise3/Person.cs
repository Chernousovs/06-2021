using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Person
    {
        private int _id;
        private static HashSet<int> ids = new HashSet<int>();

        public Person(string firstName, string lastName, string address, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            _id = !ids.Contains(id) ? id : ids.Max() + 1;
            ids.Add(_id);
        }

        public Person()
        {
            _id = ids.Any()? ids.Max() + 1 : 1;
            ids.Add(_id);
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Address { get; private set; }

        public void SetNewFirstName(string newName)
        {
            FirstName = newName;
        }

        public void SetNewLastName(string newLastName)
        {
            LastName = newLastName;
        }

        public void SetNewAddress(string newAddress)
        {
            Address = newAddress;
        }

        public virtual void Display() => Console.WriteLine($"Person info: {FirstName} {LastName} {Address}");
    }
}
