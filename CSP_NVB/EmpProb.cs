using System;

namespace EmployeeApp
{
    public class Employee
    {
        int empCode;
        string name;
        string designation;
        double basicPay;
        double hra;
        double da;
        double totalSalary;

        //  Constructor
        public Employee(int empCode, string name, string designation, double basicPay)
        {
            this.empCode = empCode;
            this.name = name;
            this.designation = designation;
            this.basicPay = basicPay;
            CalcDA();
            CalcHRA();
            CalcTotalSalary();
        }

        //  Calculate DA (45% of basicPay)
        public void CalcDA()
        {
            da = 0.45 * basicPay;
        }

        //  Calculate HRA (20% of basicPay)
        public void CalcHRA()
        {
            hra = 0.20 * basicPay;
        }

        //  Calculate Total Salary
        public void CalcTotalSalary()
        {
            totalSalary = basicPay + da + hra;
        }

        //  Show Employee Details
        public void ShowDetails()
        {
            Console.WriteLine("Employee Code   : " + empCode);
            Console.WriteLine("Name            : " + name);
            Console.WriteLine("Designation     : " + designation);
            Console.WriteLine("Basic Pay       : " + basicPay);
            Console.WriteLine("DA (45%)        : " + da);
            Console.WriteLine("HRA (20%)       : " + hra);
            Console.WriteLine("Total Salary    : " + totalSalary);
            Console.WriteLine("--------------------------------");
        }
    }

    internal class EmpProb
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, "Deep", "Manager", 50000);
            e1.ShowDetails();

            Employee e2 = new Employee(102, "Kris", "Developer", 40000);
            e2.ShowDetails();

            Console.ReadLine(); // pause console
        }
    }
}
 