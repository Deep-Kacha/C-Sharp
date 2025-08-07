//Defiene EnrollmentNo and Name properties for the student class and demonstate the use of these properties along with required data members, methods and constructors.
//Defiene EnrollmentNo and Name properties for the student class and demonstate the use of these properties along with required data members, methods and constructors.
using System;

namespace CSP_PT
{
    class Student
    {
        private int enrollmentNo;
        private string name;

        // Constructor
        public Student(int enrollmentNo, string name)
        {
            this.enrollmentNo = enrollmentNo;
            this.name = name;
        }

        // EnrollmentNo property
        public int EnrollmentNo
        {
            get { return enrollmentNo; }
            set { enrollmentNo = value; }
        }

        // Name property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Method to display student details
        public void DisplayDetails()
        {
            Console.WriteLine($"Enrollment No: {enrollmentNo}, Name: {name}");
        }
    }

    class StudDetail
    {
        static void Main(string[] args)
        {
            // Create an instance of the Student class
            Student student = new Student(48, "Krish Pansara");
            // Display student details
            student.DisplayDetails();
            // Modify properties
            student.EnrollmentNo = 34;
            student.Name = "Rushi Sorathiya";
            // Display updated details
            student.DisplayDetails();
        }
    }
}