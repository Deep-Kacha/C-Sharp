using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CSP_Pt
{
    internal class Addition
    {
        static int Add(int a, int b)// non static 
        {
            return a + b;
        }
        static int Sub(int a, int b)// non static 
        {
            return a - b;
        }
        static int Mul(int a, int b)// non static 
        {
            return a * b;
        }
        static int Div(int a, int b)// non static 
        {
            return a / b;
        }

        static void Main()
        {
            int a = 20,b = 10;
            int ra;
            ra = Add(a, b);
            Console.WriteLine("Addition : " + ra);
            ra = Sub(a,b);
            Console.WriteLine("Substaracion : " + ra);
            ra = Mul(a, b);
            Console.WriteLine("Multiplication : " + ra);
            ra = Div(a, b);
            Console.WriteLine("Division : " + ra);
        }
    }
}