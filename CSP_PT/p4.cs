using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tabale For 1 to 10
namespace CSP_PT
{
    internal class P4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j<=10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
                Console.WriteLine();
            }
        }
    }
}