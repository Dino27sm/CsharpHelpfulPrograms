using System;

namespace T07.PascalTriangleM1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());
            long[][] jaggArrey = new long[numLines][];
            jaggArrey[0] = new long[1] { 1 };
            for (int row = 1; row < numLines; row++)
            {
                int nextLineLength = jaggArrey[row - 1].Length + 1;
                long[] tempLine = new long[nextLineLength + 1];
                for (int i = 1; i < tempLine.Length - 1; i++)
                {
                    tempLine[i] = jaggArrey[row - 1][i - 1];
                }
                jaggArrey[row] = new long[nextLineLength];
                for (int k = 0; k < tempLine.Length - 1; k++)
                {
                    jaggArrey[row][k] = tempLine[k] + tempLine[k + 1];
                }
            }
            foreach (long[] rowItems in jaggArrey)
            {
                Console.WriteLine(string.Join(" ", rowItems));
            }
        }
    }
}
