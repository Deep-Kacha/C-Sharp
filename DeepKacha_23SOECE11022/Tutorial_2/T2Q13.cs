using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eepKacha_23SOECE11022.Tutorial_2
{
    class T2Q13
    {
        static void Main(string[] args)
        {
            int[] notes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            Console.Write("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Minimum number of notes required:");

            for (int i = 0; i < notes.Length; i++)
            {
                int count = amount / notes[i];
                amount = amount % notes[i];

                Console.WriteLine("Notes of Rs.{0} = {1}", notes[i], count);
            }

            Console.ReadLine();
        }
    }
}
