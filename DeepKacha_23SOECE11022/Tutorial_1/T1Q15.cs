
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepKacha_23SOECE11022
{
    internal class T1Q15
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int Count = 0;
            int temp = input;
            while (temp > 0)
            {
                temp /= 10;
                Count++;
            }
            temp= input;
            int sum = 0;
            while (temp > 0)
            {
                int digit = temp % 10;
                temp /= 10;
                sum+= (int)Math.Pow(digit, Count);
            }
            if (sum == input)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not an Armstrong Number");
            }
        }
    }
}