using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP_NVB
{
    internal class foreach_loop
    {
        static void Main(string[] args)
        {
            int[] b = { 60, 70, 80, 90, 100 };
            foreach (int var in b)
            {
                Console.WriteLine(var);
            }
        }
    }
}
