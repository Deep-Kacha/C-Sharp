using System;

namespace DeepKacha_23SOECE11022
{
    // Clock class definition
    public class Clock
    {
        // Private data members for hour, minute, second
        private int hour;
        private int min;
        private int sec;

        // No-argument constructor - initialize to 12:00:00
        public Clock()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }

        // Three-argument constructor to initialize time
        public Clock(int hour, int min, int sec)
        {
            // Basic validation (optional)
            this.hour = (hour >= 0 && hour < 24) ? hour : 0;
            this.min = (min >= 0 && min < 60) ? min : 0;
            this.sec = (sec >= 0 && sec < 60) ? sec : 0;
        }

        // Method to increment time by one second
        public void IncrementSecond()
        {
            sec++;  // Increment seconds

            if (sec == 60)  // If seconds reach 60, reset and increment minutes
            {
                sec = 0;
                min++;

                if (min == 60)  // If minutes reach 60, reset and increment hour
                {
                    min = 0;
                    hour++;

                    if (hour == 24)  // If hour reaches 24, reset to 0
                    {
                        hour = 0;
                    }
                }
            }
        }

        // Method to display time in HH:MM:SS format
        public void DisplayTime()
        {
            Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
        }

        // Getter method to return hour
        public int GetHour()
        {
            return hour;
        }

        // Getter method to return minute
        public int GetMinute()
        {
            return min;
        }

        // Getter method to return seconds
        public int GetSeconds()
        {
            return sec;
        }
    }

    // Demo class with Main method
    class T3Q2
    {
        static void Main(string[] args)
        {
            // Create clock with no-argument constructor (default 12:00:00)
            Clock clock1 = new Clock();
            Console.Write("Default time: ");
            clock1.DisplayTime();

            // Increment seconds 5 times
            Console.WriteLine("Incrementing 5 seconds:");
            for (int i = 0; i < 5; i++)
            {
                clock1.IncrementSecond();
                clock1.DisplayTime();
            }

            Console.WriteLine();

            // Create clock with parameterized constructor
            Clock clock2 = new Clock(23, 59, 57);
            Console.Write("Initialized time: ");
            clock2.DisplayTime();

            // Increment seconds 5 times to see rollover
            Console.WriteLine("Incrementing 5 seconds:");
            for (int i = 0; i < 5; i++)
            {
                clock2.IncrementSecond();
                clock2.DisplayTime();
            }

            Console.WriteLine();

            // Use getters
            Console.WriteLine($"Hour: {clock2.GetHour()}, Minute: {clock2.GetMinute()}, Seconds: {clock2.GetSeconds()}");
        }
    }
}
