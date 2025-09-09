using System;

namespace CSP_NVB
{
    internal class ConstructorOverloading
    {
        private string name;
        private int age;

        // Default Constructor
        public ConstructorOverloading()
        {
            name = "Unknown";
            age = 0;
            Console.WriteLine("Default Constructor Called");
        }

        // Constructor with Name
        public ConstructorOverloading(string name)
        {
            this.name = name;
            age = 0;
            Console.WriteLine("Constructor with Name Called");
        }

        // Constructor with Name and Age
        public ConstructorOverloading(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Constructor with Name and Age Called");
        }

        // Display Method
        public void Display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        // Main Method
        static void Main(string[] args)
        {
            ConstructorOverloading obj1 = new ConstructorOverloading();           // Calls default constructor
            obj1.Display();

            ConstructorOverloading obj2 = new ConstructorOverloading("Alice");    // Calls constructor with name
            obj2.Display();

            ConstructorOverloading obj3 = new ConstructorOverloading("Bob", 25);  // Calls constructor with name & age
            obj3.Display();

            Console.ReadLine();
        }
    }
}
