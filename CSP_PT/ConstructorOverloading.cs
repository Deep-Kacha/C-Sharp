using System;

namespace CSP_PT
{
    internal class ConstructorOverloading
    {
        private string name;
        private int age;

        // Constructor 1: Default constructor
        public ConstructorOverloading()
        {
            name = "Unknown";
            age = 0;
            Console.WriteLine("Default Constructor Called");
        }

        // Constructor 2: Parameterized constructor (1 parameter)
        public ConstructorOverloading(string name)
        {
            this.name = name;
            age = 0;
            Console.WriteLine("Constructor with Name Called");
        }

        // Constructor 3: Parameterized constructor (2 parameters)
        public ConstructorOverloading(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Constructor with Name and Age Called");
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

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
