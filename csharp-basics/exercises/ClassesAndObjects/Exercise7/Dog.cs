using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public class Dog
    {
        private string _name, _sex;
        private Dog _mother, _father;

        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
        }

        public Dog(string name, string sex, ref Dog motherData, ref Dog fatherData)
        {
            _name = name;
            _sex = sex;
            _mother = motherData;
            _father = fatherData;
        }

        public string FatherName()
        {
            if (_father != null)
            {
                return _father._name;
            }
            return "Unknown";
        }

        public bool HasSameMotherAs(Dog possibleMother)
        {
            return _mother == possibleMother._mother;
        }
    }
}