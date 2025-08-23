using System;

namespace eepKacha_23SOECE11022.Tutorial_2
{
    class T2Q10
    {
        // Method to search X in matrix
        public int matSearch(int[,] mat, int N, int M, int X)
        {
            int row = 0, col = M - 1;  // start from top-right corner

            while (row < N && col >= 0)
            {
                if (mat[row, col] == X)
                {
                    return 1;  // element found
                }
                else if (mat[row, col] > X)
                {
                    col--;  // move left
                }
                else
                {
                    row++;  // move down
                }
            }

            return 0;  // element not found
        }

        static void Main(string[] args)
        {
            T2Q10 obj = new T2Q10();

            Console.Write("Enter number of rows (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns (M): ");
            int M = Convert.ToInt32(Console.ReadLine());

            int[,] mat = new int[N, M];

            Console.WriteLine("Enter the matrix elements row-wise:");
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    mat[i, j] = Convert.ToInt32(input[j]);
                }
            }

            Console.Write("Enter the element to search (X): ");
            int X = Convert.ToInt32(Console.ReadLine());

            int result = obj.matSearch(mat, N, M, X);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
