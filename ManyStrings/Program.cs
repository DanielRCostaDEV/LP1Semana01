using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;
            string nr = $"Real number of xx with two decimals:{xx,5:f2}";
            Console.WriteLine(nr);
            string pr = $"Percentage of xx with one decimal: {xx:p1}";
            Console.WriteLine(pr);

            string hx = $"The hexadecimal value of {ii} is {ii:x}";
            Console.WriteLine(hx);
            string eu = $"The currency value of {ii} is {ii:c}";
            Console.WriteLine(eu);
            
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
