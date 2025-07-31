using System;

namespace CSP_PT
{
    internal class MethodOverloading
    {
        // Method with two int parameters
        void Sum(int x, int y)
        {
            Console.WriteLine("Sum of two integers: " + (x + y));
        }

        // Method with three int parameters
        void Sum(int x, int y, int z)
        {
            Console.WriteLine("Sum of three integers: " + (x + y + z));
        }

        // Method with double parameters
        void Sum(double x, double y)
        {
            Console.WriteLine("Sum of two doubles: " + (x + y));
        }

        // Main Method
        static void Main(string[] args)
        {
            MethodOverloading obj = new MethodOverloading();

            obj.Sum(10, 20);          // Calls Sum(int, int)
            obj.Sum(10, 20, 30);      // Calls Sum(int, int, int)
            obj.Sum(5.5, 4.5);        // Calls Sum(double, double)

            Console.ReadLine();
        }
    }
}