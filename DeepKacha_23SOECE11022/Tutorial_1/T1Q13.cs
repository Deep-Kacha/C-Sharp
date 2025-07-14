using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepKacha_23SOECE11022
{
    internal class T1Q13
    {
        public static void Main(string[] args)
        {
            Console.Write("enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibonacci series: ");
            int a = 0, b = 1, c;
            if (a < 1)
            {
                Console.Write(a + " ");
            }
            if (a <= 2)
            {
                Console.Write(b + " ");
            }
            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }

        }
    }
}