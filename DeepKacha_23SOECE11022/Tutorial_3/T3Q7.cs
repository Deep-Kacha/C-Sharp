using System;

namespace DeepKacha_23SOECE11022
{
    // Student class definition
    public class Student
    {
        // Private data members
        private int enrolmentNo;
        private string name;

        // Public property for EnrolmentNo
        public int EnrolmentNo
        {
            get { return enrolmentNo; }
            set { enrolmentNo = value; }
        }

        // Public property for Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Default constructor
        public Student()
        {
            enrolmentNo = 0;
            name = "Unknown";
        }

        // Parameterized constructor
        public Student(int enrolmentNo, string name)
        {
            this.enrolmentNo = enrolmentNo;
            this.name = name;
        }

        // Method to display student details
        public void DisplayDetails()
        {
            Console.WriteLine("Enrolment No: " + EnrolmentNo);
            Console.WriteLine("Name: " + Name);
        }
    }

    // Class T3Q7 containing the Main method
    class T3Q7
    {
        static void Main(string[] args)
        {
            // Using default constructor
            Student student1 = new Student();
            student1.DisplayDetails();

            Console.WriteLine();

            // Using parameterized constructor
            Student student2 = new Student(11022, "Deep Kacha");
            student2.DisplayDetails();

            Console.WriteLine();

            // Using properties to set values
            Student student3 = new Student();
            student3.EnrolmentNo = 23045;
            student3.Name = "Raju Ajmera    ";
            student3.DisplayDetails();
        }
    }
}
