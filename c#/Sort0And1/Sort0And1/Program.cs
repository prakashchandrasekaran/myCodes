using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort0And1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1 };
            sort0And1(ref arr);
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }

        private static void sort0And1(ref int[] arr)
        {
            int f = 0;
            int l = arr.Length - 1;
            while (f < l)
            {
                if (arr[f] == 0)
                    f++;
                if (arr[l] == 1)
                    l--;
                if (arr[f] == 1 && arr[l] == 0)
                {
                    // swapping
                    arr[f] = 0;
                    arr[l] = 1;
                    f++;
                    l--;
                }
            }
           
        }
    }
}
