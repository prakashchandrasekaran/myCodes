using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort012
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 0, 0, 1, 0, 0, 2, 0 };
            sort012(ref arr);
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }

        private static void sort012(ref int[] arr)
        {
            int f = -1;
            int m = 0;
            int l = arr.Length - 1;
            while (m < l)
            {
                if (arr[m] == 0)
                {
                    f++;
                    int temp = arr[m];
                    arr[m] = arr[f];
                    arr[f] = temp;
                    m++;
                }
                if (arr[m] == 1)
                {
                    m++;
                    // do nothing
                }
                if (arr[m] == 2)
                {
                    int temp = arr[l];
                    arr[l] = arr[m];
                    arr[m] = temp;
                    l--;
                }
            }
           
        }
    }
}
