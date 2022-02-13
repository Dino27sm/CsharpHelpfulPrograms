using System;
using System.Collections.Generic;
using System.Linq;

namespace CombinationsGeneratorM2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter all symbols to combine: ");
            List<string> inpSymbols = Console.ReadLine().Split().ToList();

            Console.Write("Enter the number of symbols in one combination: ");
            int combinationLength = int.Parse(Console.ReadLine());
            int lengthSymbolsList = inpSymbols.Count;

            if (combinationLength > lengthSymbolsList)
            {
                Console.WriteLine("Combination length must not excseed total number of symbols!");
                return;
            }
            //===============================================================================

            List<int> indexesFirstCombin = new List<int>();
            List<int> indexesLastCombin = new List<int>();
            for (int i = 0; i < combinationLength; i++)
            {
                indexesFirstCombin.Add(i);
                indexesLastCombin.Add(lengthSymbolsList - combinationLength + i);
            }
            List<int> currentIndexes = indexesFirstCombin.ToList();
            currentIndexes.Insert(0, 0);
            int currentIndexesLength = currentIndexes.Count;
            //===============================================================================

            List<string[]> allCombinations = new List<string[]>();
            while (true)
            {
                bool endCombin = true;
                for (int i = (currentIndexesLength - 1); i > 0; i--)
                {
                    if (currentIndexes[i] != indexesLastCombin[i - 1])
                    {
                        endCombin = false;
                        break;
                    }
                }
                string[] combination = new string[combinationLength];
                for (int i = combinationLength - 1; i >= 0; i--)
                {
                    combination[i] = inpSymbols[currentIndexes[i + 1]];
                }
                allCombinations.Add(combination);

                if (endCombin) break;  // To Break WHILE LOOP --------------------------

                bool isOverload = false;
                currentIndexes[currentIndexesLength - 1] += 1;
                for (int i = currentIndexesLength - 1; i > 0; i--)
                {
                    int overload = currentIndexes[i] / (indexesLastCombin[i - 1] + 1);
                    int devisionRemain = currentIndexes[i] % (indexesLastCombin[i - 1] + 1);
                    currentIndexes[i] = devisionRemain;
                    currentIndexes[i - 1] += overload;
                    if (overload > 0)
                        isOverload = true;
                }

                if (!isOverload) continue;

                int notZeroIndex = currentIndexes.FindLastIndex(x => x > 0);
                for (int i = notZeroIndex + 1; i < currentIndexesLength; i++)
                {
                    if (currentIndexes[i] == 0)
                        currentIndexes[i] = currentIndexes[i - 1] + 1;
                }
            }
            Console.WriteLine($"Total number of Combinations:  {allCombinations.Count}");
            Console.Write("Do you want to print all combinations (Y/N): ");
            string gotAnswer = Console.ReadLine();
            if (gotAnswer.ToLower() == "y")
            {
                foreach (var combinItem in allCombinations)
                {
                    Console.WriteLine(string.Join(" ", combinItem));
                }
            }
        }
    }
}
