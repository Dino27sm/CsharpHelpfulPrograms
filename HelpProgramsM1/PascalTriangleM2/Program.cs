using System;
using System.Numerics;

namespace PascalTriangleM2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Calculate Combinations of N elements of M class using BigInteger --");
            Console.Write("Enter the N: ");
            int numElements = int.Parse(Console.ReadLine());
            Console.Write("Enter the M: ");
            int numClass = int.Parse(Console.ReadLine());
            BigInteger combinationPrint = CombinationValue(numElements, numClass);
            Console.WriteLine($"Result:  {combinationPrint}");
            //string numSymbols = "" + combinationPrint;
            //Console.WriteLine($"Number of digits:  {numSymbols.Length}");
        }

        static BigInteger CombinationValue(int elementNum, int classNum)
        {
            BigInteger combinOut = -1;
            if (elementNum < 2 * classNum)
                classNum = elementNum - classNum;
            if (elementNum >= classNum && classNum >= 0)
            {
                combinOut = 1;
                for (int m = 1; m <= classNum; m++)
                    combinOut = (combinOut * elementNum--) / m;
            }
            else
                Console.WriteLine("Wrong input data");
            return combinOut;
        }
    }
}
