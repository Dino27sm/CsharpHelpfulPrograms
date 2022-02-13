using System;
using System.Linq;

namespace PermutationsWithoutRepetitions
{
    class Program
    {
        private static string[] permutation;
        private static string[] permutElements;
        private static bool[] used;

        static void Main(string[] args)
        {
            permutElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            permutation = new string[permutElements.Length];
            used = new bool[permutElements.Length];

            Console.WriteLine("============== START =============");

            GeneratePermutation(0);
        }

        private static void GeneratePermutation(int index)
        {
            if (index >= permutation.Length)
            {
                Console.WriteLine(string.Join(" ", permutation));
                return;
            }

            for (int i = 0; i < permutation.Length; i++)
            {
                if (used[i] == false)
                {
                    used[i] = true;
                    permutation[index] = permutElements[i];
                    GeneratePermutation(index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
