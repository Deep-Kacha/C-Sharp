using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepKacha_23SOECE11022
{
    internal class T1Q6
    {
        public static void Main()
        {
            int a, b, c, result;
            Console.Write("Enter Number 1: ");
            string str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.Write("Enter Number 2 : ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            Console.Write("Enter Number 3 : ");
            str = Console.ReadLine();
            c = Convert.ToInt32(str);

            result = Sum(a, b, c);
            Console.WriteLine("Sum of three numbers is: " + result);

            Console.Read();
        }
        static int Sum(int x, int y, int z)
        {
            int res;
            res = x + y + z;
            return res;
        }

    }
}