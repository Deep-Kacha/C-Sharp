using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP_NVB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ary = new int[5]; //declaration of array
            int[] ary2 = { 60, 70, 80, 90, 100 };
            //initilization of array element
            ary[0]=10;
            ary[1]=20;
            ary[2]=30;
            ary[3]=40;
            ary[4]=50;

            Console.WriteLine(ary[0]);
            Console.WriteLine(ary[1]);
            Console.WriteLine(ary[2]);
            Console.WriteLine(ary[3]);
            Console.WriteLine(ary[4]);

            for (int i = 0; i < ary2.Length; i++)
            {
                Console.WriteLine(ary2[i]);
            }
        }
    }
}
