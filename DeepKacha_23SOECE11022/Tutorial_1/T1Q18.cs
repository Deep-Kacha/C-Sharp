using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepKacha_23SOECE11022
{
    internal class T1Q18
    {
        public static void Main(string[] args)
        {
            int n = 4;
            int k = 1; // Initialize k to 1 for printing numbers in sequence
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}