using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargestContiguousSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {-1,-2,-3,-4,-5,-6,-7};
            Interval i = findLargestContiguousSum(array);
            Console.Read();
        }

        private static Interval findLargestContiguousSum(int[] array)
        {
            Interval result = new Interval(-1,-1);
            int currSum = array[0];
            int maxSum = array[0];
            int tstart = 0;
            result.start = 0;
            result.end = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if ((currSum + array[i]) > array[i])
                {
                    currSum += array[i];
                }
                else
                {
                    tstart = i;
                    // Console.WriteLine("tstart is {0}", tstart);
                    currSum = array[i];
                }

                if (currSum > maxSum)
                {
                    result.start = tstart;
                    result.end = i;
                    maxSum = currSum;
                }
            }

            Console.WriteLine("{0} - {1}", maxSum, result);

            return result;
        }
    }

    class Interval 
    { 
        public Interval(int s, int e) { start = s; end = e; } 
        public override string ToString() { return String.Format("({0}, {1})", start, end); } 
        public int start; 
        public int end;    
    }
}
