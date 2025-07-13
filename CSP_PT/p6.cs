using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP_PT
{
    internal class P6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms (n): ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int currentTerm = 0;
            for (int i = 1; i <= n; i++)
            {
                currentTerm = currentTerm * 10 + 5; // Generate the term (5, 55, 555, ...)
                sum += currentTerm; // Add the current term to the sum
            }
            Console.WriteLine("The sum of the series is: " + sum);
        }
    }
}   