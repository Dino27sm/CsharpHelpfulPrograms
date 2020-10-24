using System;
using System.Linq;

namespace MatrixPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numRows = dimension[0];
            int numCols = dimension[1];
            int[,] matrixData = new int[numRows, numCols];
            for (int row = 0; row < numRows; row++)
            {
                int[] readLine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < numCols; col++)
                    matrixData[row, col] = readLine[col];
            }

            PrintMatrix(matrixData);
        }

        public static void PrintMatrix<T>(T[,] matrixInp)
        {
            int rowsNum = matrixInp.GetLength(0);
            int colsNum = matrixInp.GetLength(1);
            for (int row = 0; row < rowsNum; row++)
            {
                T[] getLine = new T[colsNum];
                for (int col = 0; col < colsNum; col++)
                    getLine[col] = matrixInp[row, col];
                Console.WriteLine(string.Join(" ", getLine));
            }
        }
    }
}
