using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeepKacha_23SOECE11022
{
    internal class T1Q14
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int Count = 0;

            string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int[] digit = new int[10];
            int temp = input;
            while (temp > 0)
            {
                digit[Count] = temp % 10;
                temp /= 10;
                Count++;
            }
            Console.Write("OUTPUT: ");
            for (int i = Count - 1; i >= 0; i--)
            {
                Console.Write(words[digit[i]]+" ");
            }
        }
    }
}