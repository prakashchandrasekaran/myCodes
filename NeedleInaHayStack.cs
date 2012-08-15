using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeedleInaHayStack
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //Window w = new Window();
            //Console.WriteLine(w);
            //Console.ReadLine();
            Program prg = new Program();
            prg.findNeedleInaHayStack("abecdefcdxxaccd$", "adc");
            Console.ReadLine();
        }

        public Window findNeedleInaHayStack(string haystack, string needle)
        {
            Dictionary<char, int> target = new Dictionary<char, int>();
            Dictionary<char, int> found = new Dictionary<char, int>();
            int currentStart = 0;
            int currentEnd = 0;
            int optimalStart = 0;
            int optimalEnd = 0;
            int matchedLength = 0;
            foreach (char c in needle)
            {
                if (target.ContainsKey(c))
                    target[c]++;
                else
                    target[c] = 1;
                found[c] = 0;
            }
            Console.WriteLine(DictionaryToString(target));

            for (; currentEnd < haystack.Length ; )
            {

                char c = ' '; // = haystack[currentEnd];
                // Console.WriteLine(DictionaryToString(found));
                if (matchedLength == needle.Length)
                {
                    c = haystack[currentStart];
                    // shrinking phase
                    if (optimalStart == 0 && optimalEnd == 0)
                    {
                        //Console.WriteLine("came here *");
                        optimalStart = currentStart;
                        optimalEnd = currentEnd;
                    }
                    else if ((optimalEnd - optimalStart) > (currentEnd - currentStart))
                    {
                        //Console.WriteLine("came here");
                        optimalEnd = currentEnd;
                        optimalStart = currentStart;
                    }
                    //Console.WriteLine("Matched ==> " + optimalStart + " . " + optimalEnd);
                    // 2. shrink
                    if (target.ContainsKey(c))
                    {
                        if (found[c] == target[c])
                        {
                            matchedLength--;
                        }
                        found[c]--;
                    }
                    currentStart++;
                }
                else
                {
                    c = haystack[currentEnd];
                    // growing phase
                    if (target.ContainsKey(c))
                    {
                        if (found[c] < target[c])
                        {
                            matchedLength++;
                        }
                        found[c]++;
                    }
                    currentEnd++;
                }
                Console.WriteLine(DictionaryToString(found));

            }
            Console.WriteLine(optimalStart + " . " + optimalEnd);
            return null;
        }


        private string DictionaryToString(Dictionary<char,int> dic)
        {
            string result = "[";
            foreach (char key in dic.Keys)
            {
                result += "(" + key + "->" + dic[key] + ")";
            }
            result += "]";
            return result;
        }
        
    }

    class Window
    {
        int start
        {get; set;}
        int end
        {get; set;}

        public Window()
        {
            start = 0;
            end = 0;
        }

        public override string ToString()
        {
            return "(" + start + "," + end + ")";
        }

    }


}
