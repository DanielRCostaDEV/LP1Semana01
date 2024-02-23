using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "This is a tab: \t ";
            Console.WriteLine(s);

            string c = "This is a copyright \u03A9";
            Console.WriteLine(c);

        }
    }
}
