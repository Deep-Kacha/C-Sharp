using System;

namespace DeepKacha_23SOECE11022
{
    // Task 1: Create a class named 'Car'
    public class Car
    {
        // Task 2: Private data members
        private string model;
        private int year;
        private double fuel;

        // Task 3: Public method to set car details
        public void SetDetails(string model, int year, double fuel)
        {
            this.model = model;
            this.year = year;
            this.fuel = fuel;
        }

        // Task 3: Public method to display car details
        public void DisplayDetails()
        {
            Console.WriteLine("Car Model: " + model);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Fuel Level: " + fuel + " liters");
        }

        // Task 3: Public method to simulate driving the car
        public void Drive(double distance)
        {
            double fuelUsed = distance * 0.1; // Assume 10 km per liter
            if (fuel >= fuelUsed)
            {
                fuel -= fuelUsed;
                Console.WriteLine($"Drove {distance} km. Fuel left: {fuel:F2} liters.");
            }
            else
            {
                Console.WriteLine("Not enough fuel to drive that distance.");
            }
        }
    }

    // Task 4: Demo class with Main method
    class T3Q1
    {
        static void Main(string[] args)
        {
            // Task 5: Create two objects of Car

            // First Car object
            Car car1 = new Car();
            car1.SetDetails("Toyota Camry", 2020, 40.0); // Set data
            car1.DisplayDetails();                       // Display data
            car1.Drive(150);                             // Drive the car

            Console.WriteLine();

            // Second Car object
            Car car2 = new Car();
            car2.SetDetails("Honda Civic", 2022, 25.5);  // Set data
            car2.DisplayDetails();                       // Display data
            car2.Drive(100);                             // Drive the car
        }
    }
}
