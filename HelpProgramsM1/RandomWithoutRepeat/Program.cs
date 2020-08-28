using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomWithoutRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First num: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter Second num: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", RandomWithoutRepeating(firstNum, secondNum)));
        }

        static int[] RandomWithoutRepeating(int beginNum, int endNum)
        {
            Random rnd = new Random();
            if (beginNum < endNum)
            {
                int allNumbers = endNum - beginNum + 1;
                List<int> tempList = new List<int>();
                for (int i = 0; i < allNumbers; i++)
                {
                    tempList.Add(beginNum + i);
                }
                List<int> randomNoRepeated = new List<int>();
                while (tempList.Count > 0)
                {
                    int randomNum = rnd.Next(0, tempList.Count);
                    randomNoRepeated.Add(tempList[randomNum]);
                    tempList.RemoveAt(randomNum);
                }
                return randomNoRepeated.ToArray();
            }
            else
            {
                Console.WriteLine($"Error - first number < second number");
                int[] error = { -1 };
                return error;
            }
        }
    }
}
