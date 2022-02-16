using System;
using System.Linq;

namespace _06_CombinationsWithRepetition
{
    class Program
    {
        private static string[] combination;
        private static string[] combElements;
        private static int combinationLength;

        static void Main(string[] args)
        {
            combElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            combinationLength = int.Parse(Console.ReadLine());

            combination = new string[combinationLength];

            Console.WriteLine("============== START =============");

            GenerateCombination(0, 0);
        }

        private static void GenerateCombination(int index, int startIndex)
        {
            if (index >= combinationLength)
            {
                Console.WriteLine(string.Join(" ", combination));
                return;
            }
            for (int i = startIndex; i < combElements.Length; i++)
            {
                combination[index] = combElements[i];
                GenerateCombination(index + 1, i);       // for "Without Repetition" use (i + 1)
            }
        }
    }
}
