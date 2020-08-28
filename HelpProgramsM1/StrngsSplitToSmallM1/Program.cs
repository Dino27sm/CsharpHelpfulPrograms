using System;
using System.Collections.Generic;
using System.Linq;

namespace StringsSplitToSmallM1
{
    class Program
    {
        static void Main(string[] args)
        {
            string textData = Console.ReadLine();
            int splitParts = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", StringSplitInPortions(textData, splitParts)));

        }

        static List<string> StringSplitInPortions(string inpText, int numParts)
        {
            List<string> listOut = new List<string>();
            List<string> inSymbols = new List<string>();
            foreach (var item in inpText)
            {
                inSymbols.Add(item.ToString());
            }
            int inSymolsLength = inSymbols.Count;
            if (numParts <= 0) numParts = 1;
            int numInPart = inSymolsLength / numParts;
            int countSplit = 1;
            while (inSymbols.Count > 0)
            {
                if (countSplit == numInPart || inSymbols.Count == 1)
                {
                    listOut.Add(inSymbols[0]);
                    inSymbols.RemoveAt(0);
                    countSplit = 1;
                }
                else
                {
                    inSymbols[0] += inSymbols[1];
                    inSymbols.RemoveAt(1);
                    countSplit++;
                }
            }
            if (listOut.Count % numParts != 0 && listOut.Count > numParts && listOut.Count > 1)
            {
                int countAdd = listOut.Count - numParts;
                int addAtIndex = listOut.Count - 1 - countAdd;
                for (int i = 1; i <= countAdd; i++)
                {
                    listOut[addAtIndex] += listOut[addAtIndex + 1];
                    listOut.RemoveAt(addAtIndex + 1);
                }
            }
            return listOut;
        }
    }
}
