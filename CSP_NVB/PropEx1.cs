using System;

namespace CSP_PT
{
    public class PropEx1
    {
        private int id;
        private string name;
        private int age;

        public int ID
        {
            get { return id; }
            set { id = value; }
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

        public void DisplayDetails()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }

    class Program
    {
        static void Main()
        {

            PropEx1 student = new PropEx1();

            student.ID = 19;
            student.Name = "Deep Kacha";
            student.Age = 20;

            student.DisplayDetails();
        }
    }
}