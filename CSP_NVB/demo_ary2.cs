using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP_NVB
{
    internal class demo_ary2
    {
        static void Main(string[] args)
        {
            //Method = 1
            //int[,] ary = new int[2, 2];
            //ary[0,0] = 1;
            //ary[0,1] = 2;
            //ary[1,0] = 3;
            //ary[1,1] = 4;
            //Console.WriteLine("First element : " + ary[0,0]);

            //Method = 2
            //int[,] ary = { { 11, 2 }, { 3, 4 } };
            //Console.WriteLine("First element : " + ary[0, 0]);

            //output in matrix form
            //int[,] ary = { { 11, 2 }, { 3, 4 }, { 5, 6 } };
            //for (int i = 0; i < ary.GetLength(0); i++) //Nums of rows
            //{
            //    for (int j = 0; j < ary.GetLength(1); j++) //Nums of columns
            //    {
            //        Console.Write(ary[i, j] + " ");
            //    }
            //    Console.WriteLine();

            //int[,] a1 = { { 11, 2 }, { 3, 4 }, { 5, 6 } };
            //for (int i = 0; i < a1.GetLength(0); i++) //Nums of rows
            //{
            //    for (int j = 0; j < a1.GetLength(1); j++) //Nums of columns
            //    {
            //        Console.Write(a1[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] a2 = { { 8, 9 }, { 6, 13 }, { 12, 18 } };
            //for (int i = 0; i < a2.GetLength(0); i++) //Nums of rows
            //{
            //    for (int j = 0; j < a2.GetLength(1); j++) //Nums of columns
            //    {
            //        Console.Write(a2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            int[,] a1 = new int[3, 2];
            for (int i = 0; i < a1.GetLength(0); i++) //Nums of rows
            {
                for (int j = 0; j < a1.GetLength(1); j++) //Nums of columns
                {
                    Console.Write(a1[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] a2 = new int[3,2];
            for (int i = 0; i < a2.GetLength(0); i++) //Nums of rows
            {
                for (int j = 0; j < a2.GetLength(1); j++) //Nums of columns
                {
                    Console.Write(a2[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
