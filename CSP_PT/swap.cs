using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CSP_Pt
{
    internal class swap
    {
        static void Swap(ref int a, ref int b)
        {
            //first and easy way
            (a, b) = (b, a);

            //second way : 
            //int tmp = a:
            //a = b ;
            //b = tmp;

            //3rd way
            // a=a+b; 44
            // b=a-b; 
            // a=a-b;

        }
        static void Main()
            {
            int a = 11, b = 33;
            Console.WriteLine("Before Swap : a = {0} and b = {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("After Swap : a = {0} and b = {1}", a, b);
        }
    }
}