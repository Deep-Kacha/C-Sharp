using System;

namespace CSP_NVB
{
    public class Student
    {
        int rlno;
        string name;
        string branch;
        int s1, s2, s3;
        double avg;

        //  Constructor (fixed parameters, removed wrong semicolons)
        public Student(int rlno, string name, string branch, int s1, int s2, int s3)
        {
            this.rlno = rlno;
            this.name = name;
            this.branch = branch;
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            CalcAvg(); //  call method properly with ()
        }

        //  Method to calculate average
        public void CalcAvg()
        {
            avg = (s1 + s2 + s3) / 3.0;
        }

        //  Property (renamed backing field to avoid recursion issue)
        public double Average
        {
            get { return avg; } // Read-only property
        }

        // Display details
        public void ShowDetails()
        {
            Console.WriteLine("Roll No is : " + rlno);
            Console.WriteLine("Name is : " + name);
            Console.WriteLine("Branch is : " + branch);
            Console.WriteLine("Avg Marks is : " + Average);
        }
    }

    internal class StudentAvg
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1111, "Deep", "CE", 77, 23, 96);
            s1.ShowDetails();

            Student s2 = new Student(2222, "Kris", "IT", 80, 70, 60);
            s2.ShowDetails();

            Console.ReadLine(); //  pause console
        }
    }
}
