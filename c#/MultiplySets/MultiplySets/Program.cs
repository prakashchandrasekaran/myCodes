using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplySets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> str = new List<string>();
            str.Add("ad"); str.Add("ae");
            str.Add("bd"); str.Add("be");
            List<Char> c = new List<char>();
            c.Add('x'); c.Add('y'); c.Add('z');
            foreach (String s in multiply(str, c))
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }

        public static List<string> multiply(List<string> nMinus1, List<Char> current)
        {
            List<string> answer = new List<string>();
            foreach (String str in nMinus1)
            {
                foreach (Char c in current)
                {
                    answer.Add(str + c);
                }
            }
            return answer;
        }
    }
}
