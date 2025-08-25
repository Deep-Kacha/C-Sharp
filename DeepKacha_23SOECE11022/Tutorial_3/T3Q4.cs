using System;

namespace DeepKacha_23SOECE11022
{
    // Student class reused from Q3
    public class Student
    {
        private int enrolmentNo;
        private string name;
        private int age;

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

        public Student()
        {
            enrolmentNo = 0;
            name = "Unknown";
            age = 18;
        }

        public Student(int enrolmentNo, string name, int age)
        {
            this.enrolmentNo = enrolmentNo;
            this.name = name;
            Age = age;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Enrolment No: {EnrolmentNo}, Name: {Name}, Age: {Age}");
        }
    }

    // Class for Q4: create 5 students and demonstrate
    class T3Q4
    {
        static void Main(string[] args)
        {
            // Creating array to hold 5 Student objects
            Student[] students = new Student[5];

            // Initializing student objects
            students[0] = new Student(1001, "Alice", 20);
            students[1] = new Student(1002, "Bob", 21);
            students[2] = new Student(1003, "Charlie", 22);
            students[3] = new Student(1004, "Diana", 19);
            students[4] = new Student(1005, "Ethan", 23);

            // Display details of all students
            Console.WriteLine("Details of 5 Students:\n");
            foreach (Student s in students)
            {
                s.DisplayDetails();
            }
        }
    }
}
