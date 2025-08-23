//Remaining
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eepKacha_23SOECE11022.Tutorial_2
{
    class T2Q6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("You entered the following {0} command line arguments:", args.Length);

            // ---------- Missing statements ----------
            for (int i = 0; i < args.Length; i++)       // Missing statement-1
            {
                Console.WriteLine(args[i]);            // Missing statement-2
            }
            // ---------- End of missing ----------

            Console.ReadLine(); // Optional: to pause console output
        }
    }
}
