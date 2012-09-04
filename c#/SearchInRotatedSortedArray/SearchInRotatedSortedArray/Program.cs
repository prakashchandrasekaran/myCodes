using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchInRotatedSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {6,7,8,9,10,1,2,3,4,5,6};

            foreach(int X in arr) {
                int loc = searchInRotatedSortedArray(ref arr, X, 0, arr.Length - 1);
                Console.WriteLine(loc);
            }
            Console.Read();
            
        }

        private static int searchInRotatedSortedArray(ref int[] arr, int X, int first, int last)
        {
            // Console.WriteLine("Called {0} {1}", first, last);
            // Console.Read();
            if (first > last)
            {
                return -1;
            }
            else if (first == last)
            {
                if (arr[first] == X)
                    return first;
                else
                    return -1;
            }
            else
            {
                int mid = (first + last) / 2;
                if (arr[mid] >= arr[first])
                {
                    if (arr[first] <= X && arr[mid] >= X)
                    {
                        return searchInRotatedSortedArray(ref arr, X, first, mid);
                    }
                    else
                    {
                        return searchInRotatedSortedArray(ref arr, X, mid + 1, last);
                    }
                }
                else
                {
                    if (arr[mid + 1] <= X && arr[last] >= X)
                    {
                        return searchInRotatedSortedArray(ref arr, X, mid + 1, last);
                    }
                    else
                    {
                        return searchInRotatedSortedArray(ref arr, X, first, mid);
                    }
                }
            }
           
        }
    }
}
