using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepKacha_23SOECE11022
{
    internal class T1Q11
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the Name: ");
            string input = Console.ReadLine();

            Console.Write("Enter your Genter (M/F): ");
            char gender = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (gender == 'M')
            {
                Console.WriteLine($"OUTPUT: Mr.{input}");
            }
            else if (gender == 'F')
            {
                Console.WriteLine($"OUTPUT:Ms.{input}");
            }
            else
            {
                Console.WriteLine("invalid gender input. Please enter 'M' or 'F'.");
            }
        }

    }
}