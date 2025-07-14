using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepKacha_23SOECE11022
{
    internal class T1Q4
    {
        public static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter a number:");
            string str = Console.ReadLine();
            x = Convert.ToInt32(str);

            if (x % 2 == 0)
            {
                Console.WriteLine("Number Is Even");
            }
            else
            {
                Console.WriteLine("Number Is odd");
            }
            Console.Read();
        }

    }
}