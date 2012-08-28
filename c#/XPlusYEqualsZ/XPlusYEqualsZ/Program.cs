using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XPlusYEqualsZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,6,4,5,3,2};
            int sum = 6;
            foreach (Pair p in findCombinations(array, sum))
            {
                Console.WriteLine(p);
            }
            Console.Read();
        }

        private static List<Pair> findCombinations(int[] array, int sum)
        {
            List<Pair> result = new List<Pair>();
            HashSet<int> wanted = new HashSet<int>();
            foreach (int x in array)
            {
                int w = sum - x;
                wanted.Add(w);
                if (wanted.Contains(x))
                {
                    result.Add(new Pair(x, w));
                }
            }
            return result;
        }
    }

    class Pair
    {
        int a;
        int b;

        public Pair(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return String.Format("({0},{1})",a ,b);
        }
    }
}
