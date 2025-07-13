using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepKacha_23SOECE11022
{
    internal class T1Q9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the name:");
            string input = Console.ReadLine();
            string name = Togglecase(input);
            Console.WriteLine(name);
        }
        static string Togglecase(string input)
        {
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsUpper(arr[i]))
                {
                    arr[i] = char.ToLower(arr[i]);
                }
                else if (char.IsLower(arr[i]))
                {
                    arr[i] = char.ToUpper(arr[i]);
                }
            }
            return new string(arr);
        }

    }
}