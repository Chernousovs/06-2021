using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        SortedDictionary<string, string> _data; 

        public PhoneDirectory()
        {
            _data = new SortedDictionary<string, string>();
        }

        private bool ExistsInPhoneBook(string name)
        {
            return _data.ContainsKey(name);
        }

        public string GetNumber(string name) 
        {
            if (ExistsInPhoneBook(name))
            {
                return _data[name];
            }

            return null;
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }

            if (ExistsInPhoneBook(name))
            {
                _data[name] = number;
            }
            else
            {
                _data.Add(name, number);
            }
        }
    }
}