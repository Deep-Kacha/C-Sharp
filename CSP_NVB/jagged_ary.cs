using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP_NVB
{
    internal class jagged_ary
    {
        static void Main(string[] args)
        {
            int[][] jAry = new int[4][];
            jAry[0]= new int[4];
            jAry[1]= new int[3];
            jAry[2]= new int[2];
            jAry[3]= new int[1];

            Console.WriteLine("Enter Jaggad array Elements : ");
            for (int i = 0; i<jAry.Length; i++)
            {
                for (int j = 0; j<jAry[i].Length; j++)
                {
                    jAry[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
             
            Console.WriteLine("Jagged Array Is ");
            for (int i = 0; i<jAry.Length; i++)
            {
                for (int j = 0; j<jAry[i].Length; j++)
                {
                    Console.Write(jAry[i][j] + " ");
                }
            Console.WriteLine();
            }
        }
    }
}
