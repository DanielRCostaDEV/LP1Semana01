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

            string m = "One" + "string";
            Console.WriteLine(m);

            int x = 5;
            int z = 10;
            string f = $"{x} plus {z} equals to {x + z}";
            Console.WriteLine(f);
            

        }
    }
}
