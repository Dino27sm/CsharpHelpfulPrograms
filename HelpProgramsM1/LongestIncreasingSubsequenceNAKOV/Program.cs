using System;
using System.Linq;

namespace LongestIncreasingSubsequenceNAKOV
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 5 - From Fundamentals Arrays More Exercises
            int[] inpArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] storeLength = new int[inpArr.Length];
            int[] storeIndex = new int[inpArr.Length];
            int endIndex = -1;
            int maxLength = 0;
            for (int i = 0; i < inpArr.Length; i++)
            {
                storeIndex[i] = -1;
                storeLength[i] = 1;
                for (int k = 0; k < i; k++)
                {
                    if (inpArr[k] < inpArr[i] && storeLength[k] >= storeLength[i])
                    {
                        storeLength[i] = 1 + storeLength[k];
                        storeIndex[i] = k;
                    }
                }
                if (storeLength[i] > maxLength)
                {
                    maxLength = storeLength[i];
                    endIndex = i;
                }
            }
            int[] resultArr = new int[maxLength];
            for (int i = maxLength - 1; i >= 0; i--)
            {
                resultArr[i] = inpArr[endIndex];
                endIndex = storeIndex[endIndex];
            }
            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
