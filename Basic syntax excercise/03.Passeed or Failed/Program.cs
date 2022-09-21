using System;

namespace _03.Passeed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            if (n >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else if ( n < 3.00)
            {
                Console.WriteLine("Failed!");
            }
            
        }
    }
}
