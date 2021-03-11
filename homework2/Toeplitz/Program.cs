using System;

namespace Toeplitz
{
    class Program
    {
        //判断是否是托普利茨矩阵
        public bool isToeplitzMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; ++row)
            {
                for (int col = 0; col < matrix[0].Length; ++col)
                {
                    if (row > 0 && col > 0 && matrix[row][col] != matrix[row - 1][col - 1])
                        return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入矩阵行数：");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入矩阵列数：");
            int N = int.Parse(Console.ReadLine());
            int[][] matrix = new int[M][];
            Console.WriteLine("请输入此矩阵：");
            for(int i = 1 ; i <= M ; i ++)
            {
                for (int j = 1; j <= N; j ++)
                {
                    matrix[i][j] = int.Parse(Console.ReadLine());
                    isToeplitzMatrix(matrix);
                }
            }
        }
    }
}