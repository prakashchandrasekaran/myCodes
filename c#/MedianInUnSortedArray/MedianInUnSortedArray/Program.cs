using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedianInUnSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 1, 1, 4, 6, 9, 2, 7, 8, 1, 3, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                int medianLocation = findMedianInSortedArray(arr, i + 1, 0 , arr.Length - 1);
                Console.WriteLine(medianLocation);
            }
            Console.Read();
        }

        private static int findMedianInSortedArray(int[] arr, int k, int first, int last)
        {
            if (arr == null || arr.Length == 0)
                return -1;
            if (k > (last - first + 1))
            {
                return -1;
            }
            // partition using pivot element
            int pivotElement = arr[last];
            int itr = first;
            int mid = first - 1;
            while (itr < last)
            {
                if (arr[itr] < pivotElement)
                {
                    int temp = arr[mid + 1];
                    arr[mid + 1] = arr[itr];
                    arr[itr] = temp;
                    mid++;
                }
                itr++;
            }
            // swap pivot
            arr[last] = arr[mid + 1];
            arr[mid + 1] = pivotElement;
            mid++;
            // decide based on pivots new location
            int rank = mid - first + 1;
            if ((rank) == k)
            {
                return arr[mid];
            }
            else
            {
                if (rank > k)
                {
                    return findMedianInSortedArray(arr, k, first, mid - 1);
                }
                else
                {
                    return findMedianInSortedArray(arr, k - rank, mid + 1, last);
                }
            }
        }
    }
}

