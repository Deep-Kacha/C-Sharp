using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eepKacha_23SOECE11022.Tutorial_2
{
    class T2Q4
    {
        static void Main(string[] args)
        {
            // Input two numbers
            Console.Write("Enter first number (A): ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number (B): ");
            int B = Convert.ToInt32(Console.ReadLine());

            // Arithmetic Operators
            Console.WriteLine("\n--- Arithmetic Operations ---");
            Console.WriteLine("A + B = " + (A + B));
            Console.WriteLine("A - B = " + (A - B));
            Console.WriteLine("A * B = " + (A * B));
            Console.WriteLine("A / B = " + ((float)A / B)); // Type casting to float
            Console.WriteLine("A % B = " + (A % B));

            // Relational Operators
            Console.WriteLine("\n--- Relational Operations ---");
            Console.WriteLine("A == B: " + (A == B));
            Console.WriteLine("A != B: " + (A != B));
            Console.WriteLine("A > B: " + (A > B));
            Console.WriteLine("A < B: " + (A < B));
            Console.WriteLine("A >= B: " + (A >= B));
            Console.WriteLine("A <= B: " + (A <= B));

            // Logical Operators
            Console.WriteLine("\n--- Logical Operations ---");
            bool condition1 = A > 0;
            bool condition2 = B > 0;
            Console.WriteLine("A > 0 && B > 0: " + (condition1 && condition2));
            Console.WriteLine("A > 0 || B > 0: " + (condition1 || condition2));
            Console.WriteLine("!(A > 0): " + (!condition1));

            // Bitwise Operators
            Console.WriteLine("\n--- Bitwise Operations ---");
            Console.WriteLine("A & B = " + (A & B));
            Console.WriteLine("A | B = " + (A | B));
            Console.WriteLine("A ^ B = " + (A ^ B));
            Console.WriteLine("~A = " + (~A));
            Console.WriteLine("A << 1 = " + (A << 1));
            Console.WriteLine("B >> 1 = " + (B >> 1));

            // Assignment Operators
            Console.WriteLine("\n--- Assignment Operations ---");
            int C = A;
            C += B;
            Console.WriteLine("C += B: " + C);
            C -= B;
            Console.WriteLine("C -= B: " + C);
            C *= B;
            Console.WriteLine("C *= B: " + C);
            C /= B;
            Console.WriteLine("C /= B: " + C);
            C %= B;
            Console.WriteLine("C %= B: " + C);

            // Other data types
            Console.WriteLine("\n--- Using Other Data Types ---");

            float floatVal = 12.5f;
            double doubleVal = 99.99;
            char ch = 'Z';
            string name = "DeepKacha";
            bool isEven = (A % 2 == 0);

            Console.WriteLine("Float value: " + floatVal);
            Console.WriteLine("Double value: " + doubleVal);
            Console.WriteLine("Character: " + ch);
            Console.WriteLine("String: " + name);
            Console.WriteLine("Is A even? " + isEven);

            Console.ReadLine();
        }
    }
}
