using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSP_PT
{
    internal class OutDemo
    {
        static void Change(ref int a, ref int b)
        {
            a = 100;
            b = 200;
        }
        static void Update(out int x, out int y)
        {
            x = 100;
            y = 200;
        }
        static void Main()
        {
            int a = 10, b = 20;
            int x = 10 ,y = 20;
            Console.WriteLine("Before Change : a = {0}, b = {1}", a, b);
            Change(ref a, ref b);
            Console.WriteLine("After Change : a = {0}, b = {1}", a, b);

            Console.WriteLine("Before Update : x = {0}, y = {1}", x, y);
            Update(out x, out y);
            Console.WriteLine("After Update : x = {0}, y = {1}", x, y);
        }
    }
}
