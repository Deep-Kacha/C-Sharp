using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eepKacha_23SOECE11022.Tutorial_2
{
    class T2Q5
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];      // Declare array
            int sum = 0;                 // Initialize sum

            // Input loop
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Element {0}: ", i);   // Prompt
                string str = Console.ReadLine();           // Read input
                arr[i] = Convert.ToInt32(str);             // Convert and store in array
            }

            // Sum loop
            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];   // Add each element to sum
            }

            Console.WriteLine("Sum of Elements : {0}", sum);  // Output sum

            Console.Read();  // Wait for key press
        }
    }
}
