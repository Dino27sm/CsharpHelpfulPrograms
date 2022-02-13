using System;
using System.Linq;

namespace PermutationsWithoutRepetitions_M1
{
    class Program
    {
        private static string[] permutation;

        static void Main(string[] args)
        {
            permutation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

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

            GeneratePermutation(index + 1);

            for (int i = index + 1; i < permutation.Length; i++)
            {
                SwapElm(index, i);
                GeneratePermutation(index + 1);
                SwapElm(index, i);
            }
        }

        private static void SwapElm(int firstIndex, int secondIndex)
        {
            string temp = permutation[firstIndex];
            permutation[firstIndex] = permutation[secondIndex];
            permutation[secondIndex] = temp;
        }
    }
}
