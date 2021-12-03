using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
 
            List<int> convertedDigitList = new List<int>();

            char[] charTextArray = text.ToCharArray();
            foreach (var letter in charTextArray)
            {
                convertedDigitList.Add(LetterToDigit(letter));
            }

            Console.WriteLine(string.Concat(convertedDigitList));
        }

        public static int LetterToDigit(char letter)
        {
            int convertedDigit;
            switch (letter)
            {
                case 'a': case 'b': case 'c': case '2':
                    convertedDigit = 2;
                    break;
                case 'd': case 'e': case 'f': case '3':
                    convertedDigit = 3;
                    break;
                case 'g': case 'h': case 'i': case '4':
                    convertedDigit = 4;
                    break;
                case 'j': case 'k': case 'l': case '5':
                    convertedDigit = 5;
                    break;
                case 'm': case 'n': case 'o': case '6':
                    convertedDigit = 6;
                    break;
                case 'p': case 'q': case 'r': case 's': case '7':
                    convertedDigit = 7;
                    break;
                case 't': case 'u': case 'v': case '8':
                    convertedDigit = 8;
                    break;
                case 'w': case 'x': case 'y': case 'z': case '9':
                    convertedDigit = 9;
                    break;
                case ' ': case '0':
                    convertedDigit = 0;
                    break;
                default:
                    convertedDigit = 1;
                    break;
            }

            return convertedDigit;
        }
    }


}
