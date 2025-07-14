using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepKacha_23SOECE11022
{
    internal class T1Q21
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("input number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            int sum = 0;
            Console.Write("Series: ");
            for (int i = 1; i <= n; i++)
            {
                temp = temp * 10 + num;
                Console.Write(temp);
                if (i < n)
                {
                    Console.Write(" + ");
                }
                sum+= temp;
            }
            Console.WriteLine();
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}