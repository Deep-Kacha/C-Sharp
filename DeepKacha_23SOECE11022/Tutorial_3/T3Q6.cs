using System;

namespace LineApplication
{
    class Line
    {
        private double length;   // Length of a line

        // Constructor with default value
        public Line()
        {
            length = 10.0; // Missing statement-1
            Console.WriteLine("Object is being created, length = " + length); // Missing statement-2
        }

        // Method to set the length
        public void setLength(double len)
        {
            length = len; // Missing statement-3
        }

        // Method to get the length
        public double getLength()
        {
            return length; // Missing statement-4
        }
    }

    class TestLine
    {
        static void Main(string[] args)
        {
            Line line = new Line(); // Object creation

            // Set line length
            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();
        }
    }
}
