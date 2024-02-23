using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input (Whole n.) and string to int
            Console.WriteLine("Please enter a whole number: ");
            string tint = Console.ReadLine();
            int sint = int.Parse(tint);
            
            //User input (Real n.) and string to float
            Console.WriteLine("Please enter a real number: ");
            string tf = Console.ReadLine();
            float stf = float.Parse(tf);
            
            //Total of the 2 numbers
            float total = sint + stf;
            Console.WriteLine($"The total of {sint} + {sint} is {total}");
        }
    }
}
