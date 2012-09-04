using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionAndTailRecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5, 1));
            Console.Read();
        }

        public static int factorial(int n, int answer)
        {
            if (n <= 1)
                return answer;
            else
            {
               return factorial(n - 1, n * answer);
            }
        }
    }
}
