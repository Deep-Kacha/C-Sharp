using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSP_PT

{
    class Student
    {
        private string firstName;
        //private string lastName;
        //1st method
        public string getFirstName()
        {
            return firstName;
        }
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }//
        //2nd method
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }//
    }
    class Test
    {
        public static void Main()
        {
            Student obj = new Student();
            //1st method
            obj.setFirstName("John");
            Console.WriteLine("First Name: " + obj.getFirstName());
            //2nd method
            obj.FirstName = "Jane";
            Console.WriteLine("First Name: " + obj.FirstName);
        }
    }
}
