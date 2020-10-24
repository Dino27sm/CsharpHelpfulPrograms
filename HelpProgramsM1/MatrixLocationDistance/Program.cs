using System;
using System.Linq;

namespace MatrixLocationDistance
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numRows = dimension[0];
            int numCols = dimension[1];
            string[,] matrixField = new string[numRows, numCols];
            for (int row = 0; row < numRows; row++)
            {
                string[] readLine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < numCols; col++)
                    matrixField[row, col] = readLine[col];
            }

            int[] xLocation = new int[2];
            int[] yLocation = new int[2];
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (matrixField[row, col] == "x")
                    {
                        xLocation[0] = row;
                        xLocation[1] = col;
                    }
                    if (matrixField[row, col] == "y")
                    {
                        yLocation[0] = row;
                        yLocation[1] = col;
                    }
                }
            }
            int xyDistance = GetDistanceBetweenTwoElements(xLocation, yLocation);
            Console.WriteLine($"The distance is: {xyDistance}");

            int xyLeftDistance = LeftDistanceBetweenTwoElements(matrixField, xLocation, yLocation);
            Console.WriteLine($"The LEFT distance is: {xyLeftDistance}");

            int xyRightDistance = RightDistanceBetweenTwoElements(matrixField, xLocation, yLocation);
            Console.WriteLine($"The RIGHT distance is: {xyRightDistance}");

            int xyZigZagDistance = ZigZagRightDistanceBetweenTwoElements(matrixField, xLocation, yLocation);
            Console.WriteLine($"The Zig-Zag to RIGHT distance is: {xyZigZagDistance}");
        }

        public static int GetDistanceBetweenTwoElements(int[] locationOne, int[] locationTwo)
        {
            int rowDistance = Math.Abs(locationOne[0] - locationTwo[0]);
            int colDistance = Math.Abs(locationOne[1] - locationTwo[1]);
            return (rowDistance + colDistance);
        }

        public static int ZigZagRightDistanceBetweenTwoElements<T>(T[,] inpMatrix, int[] locationOne, int[] locationTwo)
        {
            int distance = -1;
            int rows = inpMatrix.GetLength(0);
            int cols = inpMatrix.GetLength(1);
            bool isInside = (locationOne[0] >= 0 && locationOne[0] < rows && locationOne[1] >= 0 && locationOne[1] < cols &&
                locationTwo[0] >= 0 && locationTwo[0] < rows && locationTwo[1] >= 0 && locationTwo[1] < cols);
            if (isInside)
            {
                int rowDistance = Math.Abs(locationOne[0] - locationTwo[0]);
                int sumColumnDistance = 0;
                if (rowDistance % 2 != 0)
                    sumColumnDistance = (cols - 1 - locationOne[1]) + (cols - 1 - locationTwo[1]);
                else
                    sumColumnDistance = (cols - 1 - locationOne[1]) + locationTwo[1];
                distance = (rowDistance - 1) * cols + sumColumnDistance + 1;
            }
            return distance;
        }

        public static int LeftDistanceBetweenTwoElements<T>(T[,] inpMatrix, int[] locationOne, int[] locationTwo)
        {
            int distance = - 1;
            int rows = inpMatrix.GetLength(0);
            int cols = inpMatrix.GetLength(1);
            bool isInside = (locationOne[0] >= 0 && locationOne[0] < rows && locationOne[1] >= 0 && locationOne[1] < cols &&
                locationTwo[0] >= 0 && locationTwo[0] < rows && locationTwo[1] >= 0 && locationTwo[1] < cols);
            if (isInside)
            {
                int rowDistance = Math.Abs(locationOne[0] - locationTwo[0]);
                int sumLeftDistance = locationOne[1] + locationTwo[1];
                distance = rowDistance + sumLeftDistance;
            }
            return distance;
        }

        public static int RightDistanceBetweenTwoElements<T>(T[,] inpMatrix, int[] locationOne, int[] locationTwo)
        {
            int distance = -1;
            int rows = inpMatrix.GetLength(0);
            int cols = inpMatrix.GetLength(1);
            bool isInside = (locationOne[0] >= 0 && locationOne[0] < rows && locationOne[1] >= 0 && locationOne[1] < cols &&
                locationTwo[0] >= 0 && locationTwo[0] < rows && locationTwo[1] >= 0 && locationTwo[1] < cols);
            if (isInside)
            {
                int rowDistance = Math.Abs(locationOne[0] - locationTwo[0]);
                int sumRightDistance = (cols - 1 - locationOne[1]) + (cols - 1 - locationTwo[1]);
                distance = rowDistance + sumRightDistance;
            }
            return distance;
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
                Console.WriteLine(string.Join("", getLine));
            }
        }
    }
}
