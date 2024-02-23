using System;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 4 real numbers:");
            string n1 = Console.ReadLine();
            double num1 = double.Parse(n1);
            
            string n2 = Console.ReadLine();
            double num2 = double.Parse(n2);
            
            string n3 = Console.ReadLine();
            double num3 = double.Parse(n3);
            
            string n4 = Console.ReadLine();
            double num4 = double.Parse(n4);

            //Print the numbers
            Console.WriteLine($"{num1,2:f2}\n{num2,2:f2} \n{num3,2:f2}\n{num4,2:f2}");
        }
    }
}
