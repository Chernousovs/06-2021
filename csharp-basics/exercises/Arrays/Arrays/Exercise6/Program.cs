using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            int[] arr = new int[10];
            int[] arr2 = new int[10];

            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(min, max);
            }

            for (int j = 0; j < arr.Length; j++)
            {
                arr2[j] = arr[j];
            }

            arr[^1] = -7;
            Console.WriteLine("Array1 : " + string.Join("," , arr));
            Console.WriteLine("Array2 : " + string.Join("," , arr2));
        }
    }
}
