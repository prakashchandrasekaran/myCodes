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
            Console.WriteLine(prg.findNeedleInaHayStack("abecdefcadxxaccd$", "adc"));
            Console.ReadLine();
        }

        public String findNeedleInaHayStack(string haystack, string needle)
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
            // Console.WriteLine(DictionaryToString(target));

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
                // Console.WriteLine(DictionaryToString(found));

            }
            // Console.WriteLine(optimalStart + " . " + optimalEnd);
            // return new Window(optimalStart, optimalEnd - 1);
            return optimalStart + "," + (optimalEnd - 1);
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

    class Window : IComparable, IEqualityComparer<Window>
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

        public Window(int s, int e)
        {
            this.start = s;
            this.end = e;
        }

        public override string ToString()
        {
            return "(" + start + "," + end + ")";
        }

       

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            Window newWindow = obj as Window;

            if (newWindow == null)
                throw new ArgumentException("object is not of type window");

            if (newWindow.start == start && newWindow.end == end)
            {
                return 0;
            }
            else if ((newWindow.end - newWindow.start) > (end - start))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    
        public bool  Equals(Window x, Window y)
        {
            return (x.start == y.start) && (x.end == y.end);
        }

        public int  GetHashCode(Window obj)
        {
 	        throw new NotImplementedException();
        }
}


}
