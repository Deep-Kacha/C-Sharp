using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eepKacha_23SOECE11022.Tutorial_2
{
    class T2Q14
    {
        static void Main(string[] args)
        {
            Console.Write("Input the marks obtained in Maths : ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Physics : ");
            int physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry : ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            bool eligible = false;

            if (maths >= 65 && physics >= 55 && chemistry >= 50)
            {
                int total = maths + physics + chemistry;
                int mathPhysicsTotal = maths + physics;

                if (total >= 180 || mathPhysicsTotal >= 140)
                {
                    eligible = true;
                }
            }

            if (eligible)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }

            Console.ReadLine();
        }
    }
}
