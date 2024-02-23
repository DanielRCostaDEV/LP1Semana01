using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
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
            
        }
    }
}
