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
            sortIt1(ref array);
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

        private static void sortIt1(ref int[] array)
        {
            int i, j, C;
            for (i = 0; i < array.Length; i++)
            {
                for (j = i - 1, C = array[i]; j >= 0 && array[j] > C; j--)
                {
                    array[j + 1] = array[j];
                }
                array[j + 1] = C;
            }
        }
    }
}
