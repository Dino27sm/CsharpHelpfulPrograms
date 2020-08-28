using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingUp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inpList = Console.ReadLine().Split().Select(d => int.Parse(d)).ToList();
            int[] integerArr = inpList.ToArray();

            int[] integerOut = SortIncreasingValues(integerArr);
            Console.WriteLine(string.Join(" ", integerOut));

        }

        static double[] SortIncreasingValues(double[] numArr)
        {
            double[] localArr = numArr.ToArray();
            for (int index = 1; index < localArr.Length; index++)
            {
                int lastIndex = index;
                while (localArr[lastIndex] < localArr[lastIndex - 1])
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

        static int[] SortIncreasingValues(int[] numArr)
        {
            int[] localArr = numArr.ToArray();
            for (int index = 1; index < localArr.Length; index++)
            {
                int lastIndex = index;
                while (localArr[lastIndex] < localArr[lastIndex - 1])
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
