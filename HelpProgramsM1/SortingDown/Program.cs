using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingDown
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inpList = Console.ReadLine().Split().Select(x => double.Parse(x)).ToList();
            int[] integerArr = inpList.Select(num => (int)num).ToArray();

            int[] outArr = SortDecreasingValues(integerArr);
            Console.WriteLine(string.Join(" ", outArr));

        }

        static double[] SortDecreasingValues(double[] numArr)
        {
            double[] localArr = numArr.ToArray();
            for (int index = 1; index < localArr.Length; index++)
            {
                int lastIndex = index;
                while (localArr[lastIndex] > localArr[lastIndex - 1])
                {
                    double temp = localArr[lastIndex - 1];
                    localArr[lastIndex - 1] = localArr[lastIndex];
                    localArr[lastIndex] = temp;
                    if (lastIndex - 1 >= 1) lastIndex--;
                    else break;
                }
            }
            return localArr;
        }

        static int[] SortDecreasingValues(int[] numArr)
        {
            int[] localArr = numArr.ToArray();
            for (int index = 1; index < localArr.Length; index++)
            {
                int lastIndex = index;
                while (localArr[lastIndex] > localArr[lastIndex - 1])
                {
                    int temp = localArr[lastIndex - 1];
                    localArr[lastIndex - 1] = localArr[lastIndex];
                    localArr[lastIndex] = temp;
                    if (lastIndex - 1 >= 1) lastIndex--;
                    else break;
                }
            }
            return localArr;
        }
    }
}
