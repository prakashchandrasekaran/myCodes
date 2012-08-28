using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {7,5,6,3,1,2,4};
            sortIt(ref array);
            foreach (int x in array)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }

        private static void sortIt(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                int C = array[i];
                while (j >= 0 && array[j] > C)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = C;
            }
        }
    }
}
