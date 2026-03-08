using System;

namespace ArithmeticOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 5;

            Console.WriteLine("Addition is: " + (x + y));
            Console.WriteLine("Subtraction is: " + (x - y));
            Console.WriteLine("Multiplication is: " + (x * y));
            Console.WriteLine("Division is: " + (x / y));

            Console.ReadLine();
        }
    }
}