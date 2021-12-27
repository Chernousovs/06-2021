using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Date
    {
        private int _month, _day, _year;
        public Date(int month, int day, int year)
        {
            _month = month;
            _day = day;
            _year = year;
        }

        public int Month => _month;
        public int Day => _day;
        public int Year => _year;

        public void DisplayDate()
        {
            Console.WriteLine($"Date is {Month} / {Day} / {Year}");
        }
    }
}
