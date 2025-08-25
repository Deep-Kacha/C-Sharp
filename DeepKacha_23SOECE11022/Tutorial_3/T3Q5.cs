//Remaining
using System;

namespace ConsoleApplication
{
    class Product
    {
        // Data members
        int pcode;
        string pname;
        string mname;

        // Constructor to initialize data members
        public Product(int pcd, string pnm, string mnm)
        {
            pcode = pcd;
            pname = pnm;
            mname = mnm;
        }

        // Method to display product details
        public void Display()
        {
            Console.WriteLine("\nProduct Code:= P" + pcode.ToString("D3")); // formatting to show P001, P002...
            Console.WriteLine("\nProduct Name:= " + pname);
            Console.WriteLine("\nManufacturer Name:= " + mname);
        }
    }

    public class TestProduct
    {
        public static void Main(string[] args)
        {
            int n = args.Length;

            if (n < 3)
            {
                Console.WriteLine("Syntax Error\n");
                Console.WriteLine("Must Have THREE Arguments\n");
                Console.WriteLine("Please, Write as [csc TestProduct ProductCode ProductName Manufacturer] \n");
            }
            else
            {
                // Parse inputs
                int pcd;
                bool parseSuccess = int.TryParse(args[0], out pcd);
                if (!parseSuccess)
                {
                    Console.WriteLine("Product Code should be an integer (without 'P'). For example, '001'.");
                    return;
                }

                string pnm = args[1];
                string mnm = args[2];

                // Create Product object
                Product p = new Product(pcd, pnm, mnm);

                // Display details
                p.Display();

                Console.ReadLine();
            }
        }
    }
}
