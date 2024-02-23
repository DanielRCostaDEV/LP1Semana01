using System;
using System.Reflection.PortableExecutable;
using System.Text;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            sbyte sb = 8;
            Console.WriteLine($"The value of sbyte is {sb} ");
            
            short sh = 16;
            Console.WriteLine($"The value of short is {sh} ");
            
            int inte = 42527;
            Console.WriteLine($"The value of int is {inte} ");
            
            long lo = 42528;
            Console.WriteLine($"The value of long is {lo}" + 'L');
            
            byte by = 8;
            Console.WriteLine($"The value of byte is {by} ");
            
            ushort bugs = 0;
            Console.WriteLine($"The value of ushort is {bugs} ");
            
            uint ui = 32;
            Console.WriteLine($"The value of uint is {ui}" + 'U');
            
            ulong ul = 33;
            Console.WriteLine($"The value of ulong is {ul}" + 'U' + 'L');
            
            char ch = 'N';
            Console.WriteLine($"The value of char is {ch} ");


            char ussr = '\u262d';
            Console.WriteLine($"{ussr}");

            char pl = '\u2708';
            Console.WriteLine($"{pl}");

            char ht = '\u2660';
            Console.WriteLine($"{ht}");

            float fl = 42;
            Console.WriteLine($"The value of float is {fl}" + 'f');

            double db = 1.2345678901234567e+300;
            Console.WriteLine($"The value of double is {db}" + ';');

            decimal de = 1342845;
            Console.WriteLine($"The value of decimal is {de}" + 'm');

            bool dinis = false;
            Console.WriteLine(dinis);

            bool bruno = 5 > 3;
            Console.WriteLine($"{bruno}");
        }
    }
}
