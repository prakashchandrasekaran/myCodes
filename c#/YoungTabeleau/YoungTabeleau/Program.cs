using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoungTabeleau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { 
                    {1,4,5,7}, 
                    {3,6,10,12}, 
                    {8,9,15,18}, 
                    {13,16,17,20}, 
            };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Found @ {0} ", searchInYoungTabeleau(array, array[i,j]));
                }
            }
            
            Console.Read();
        }

        private static Pair searchInYoungTabeleau(int[,] array, int X)
        {
            int xLen = array.GetLength(0);
            int yLen = array.GetLength(1);
            int i = 0;
            int j = yLen - 1;
            int C = -1;
            while( i < xLen && j > -1) 
            {
                C = array[i, j];
                if (C == X)
                    return new Pair(i, j);
                else if (C < X)
                    i++;
                else
                    j--;
            }
            return new Pair(-1, -1);
        }
    }

    class Pair
    {
        public Pair(int a, int b)
        {
            x = a;
            y = b;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", x, y);
        }

        int x;
        int y;
    }
}
