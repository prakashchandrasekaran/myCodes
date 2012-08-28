using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8,4,2,6,7,5,3,1,10,9, -1,-4,-2};

            SortIt(ref array, 0, array.Length - 1);
            foreach (int x in array)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }

        private static void SortIt(ref int[] array, int start, int end)
        {
            if (start < end)
            {
                Console.WriteLine("Called {0} {1}", start, end);
                int pivot = array[end];
                int mid = start - 1;
                int itr = start;
                while (itr < end)
                {
                    if (array[itr] < pivot)
                    {
                        int temp = array[itr];
                        array[itr] = array[mid + 1];
                        array[mid + 1] = temp;
                        mid++;
                    }
                    itr++;
                }
                array[end] = array[mid + 1];
                array[mid + 1] = pivot;
                mid++;
                SortIt(ref array, start, mid - 1);
                SortIt(ref array, mid + 1, end);
            }
        }
    }
}
