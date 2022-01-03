using System;
using System.Runtime.InteropServices;

namespace Exercise6
{
    public class Program
    {
        static void Main(string[] args)
        {
            var array1 = FirstArray();
            var array2 = SecondArray(array1);
            ChangeLast(array1);
            Console.WriteLine(WriteFirstArray(array1));
            Console.WriteLine(WriteSecondArray(array2));
        }

        public static Random CreateRandomNumber()
        {
            Random randNum = new Random();
            return randNum;
        }

        public static int[] FirstArray()
        {
            int min = 0;
            int max = 100;
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = CreateRandomNumber().Next(min, max);
            }

            return arr;
        }

        public static int[] SecondArray(int[] arr)
        {
            int[] arr2 = new int[arr.Length];

            for (int j = 0; j < arr.Length; j++)
            {
                arr2[j] = arr[j];
            }

            return arr2;
        }

        public static void ChangeLast(int[] arr)
        {
            arr[^1] = -7;
        } 

        public static string WriteFirstArray(int[] arr)
        {
            
            return "Array1 : " + string.Join(",", arr);
        }

        public static string WriteSecondArray(int[] arr2)
        {
            return "Array2 : " + string.Join(",", arr2);
        }
    }
}
