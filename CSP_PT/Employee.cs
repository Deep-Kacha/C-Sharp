using System;

namespace CSP_PT
{
    class Employee
    {
        int empId;
        string Name;
        string City;
        public Employee()
        {
        }
        public Employee(int empId, string Name)
        {
            this.empId = empId;
            this.Name = Name;
        }
        public int Employee(int empId,string Name,string City):this(empId,Name)
        {
            this.City = City;
        }
        public void Display()
        { }
}
    class 
