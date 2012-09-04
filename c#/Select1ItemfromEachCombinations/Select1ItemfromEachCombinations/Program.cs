using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Select1ItemfromEachCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] input = new char[3][];
            input[0] = new char[] { 'a', 'b', 'c'};
            input[1] = new char[] { '1', '2' };
            input[2] = new char[] { '#', '$', '%', '*' };

            int itr = 0;
            foreach (char s in multiply(input))
            {
                if (itr % input.Length == 0)
                    Console.WriteLine();
                Console.Write("{0} ", s);
                itr++;
            }
            Console.Read();
        }

        public static char[,] multiply(char[][] sets)
        {
            if (sets == null || sets.Length == 0)
                return null;

            int numResults = 1;

            foreach (char[] set in sets)
            {
                if (set == null || set.Length == 0)
                    return null;
                numResults *= set.Length;
            }

            char[,] result = new char[numResults, sets.Length];
            int times = 1;
            int frequency = numResults;
            int itr;

            for (int i = 0; i < sets.Length; i++) 
            {
                frequency /= sets[i].Length;
                itr = 0;
                for (int j = 0; j < times; j++)
                {
                    foreach (char c in sets[i])
                    {
                        for (int k = 0; k < frequency; k++)
                        {
                            result[itr, i] = c;
                            itr++;
                        }
                    }
                }
                times *= sets[i].Length;
            }
            return result;
        }
    }
}
