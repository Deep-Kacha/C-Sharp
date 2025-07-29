using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSP_PT
{
    public class Emp
    {
        int empId;
        string empName;
        double empSalary;

        public void getData(int empId, string empName, double empSalary)
        {
            this.empId = empId;
            this.empName = empName;
            this.empSalary = empSalary;
        }
        public void showData()
        {
            Console.WriteLine("Emp Id : "+ empId);
            Console.WriteLine("Emp Name : "+ empName);
            Console.WriteLine("Emp Salary : "+ empSalary);
        }
        internal class Demo
        {
            public static void Main()
            {
                Emp e1 = new Emp();
                e1.getData(111,"Deep",200.00);
                e1.showData();

                Emp e2 = new Emp();
                e2.getData(112, "Meet", 300.00);
                e2.showData();
                //e1.empName = "Jane Doe";  //Not possible as empName is private
            }
        }
    }

}
