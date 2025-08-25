using System;

namespace DeepKacha_23SOECE11022
{
    // Student class definition
    public class Student
    {
        // Private data members
        private int enrolmentNo;
        private string name;
        private int age;

        // Public properties for data members
        public int EnrolmentNo
        {
            get { return enrolmentNo; }
            set { enrolmentNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    Console.WriteLine("Age must be positive.");
            }
        }

        // Default constructor
        public Student()
        {
            enrolmentNo = 0;
            name = "Unknown";
            age = 18;
        }

        // Parameterized constructor
        public Student(int enrolmentNo, string name, int age)
        {
            this.enrolmentNo = enrolmentNo;
            this.name = name;
            Age = age;  // Use property to validate
        }

        // Method to display student details
        public void DisplayDetails()
        {
            Console.WriteLine($"Enrolment No: {EnrolmentNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    // TestStudent class with Main method
    class TestStudent
    {
        static void Main(string[] args)
        {
            // Create student object using default constructor
            Student student1 = new Student();
            Console.WriteLine("Student 1 details (default constructor):");
            student1.DisplayDetails();

            Console.WriteLine();

            // Create student object using parameterized constructor
            Student student2 = new Student(11022, "Deep Kacha", 21);
            Console.WriteLine("Student 2 details (parameterized constructor):");
            student2.DisplayDetails();

            Console.WriteLine();

            // Modify student1 details using properties
            student1.EnrolmentNo = 23045;
            student1.Name = "Raju Ajmera";
            student1.Age = 20;
            Console.WriteLine("Student 1 details after modification:");
            student1.DisplayDetails();
        }
    }
}
