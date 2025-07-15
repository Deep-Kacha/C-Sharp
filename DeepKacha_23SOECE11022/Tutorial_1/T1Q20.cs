using System;

namespace DeepKacha_23SOECE11022
{
    internal class T1Q20
    {
        public static void Main(string[] args)
        {
            int n = 4;
            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num);
                    num++;
                    if (j < i)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(); // Move to next line after each row
            }
        }
    }
}
