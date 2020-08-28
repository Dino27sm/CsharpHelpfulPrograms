using System;
using System.Collections.Generic;
using System.Linq;

namespace SwapIndexesList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inpList = new List<string>() { "0", "1", "2", "3", "4", "5", "6" };
            List<string> printList = SwapListIdexes(inpList, 5, 1);
            Console.WriteLine(string.Join(" ",printList));
        }
        static List<string> SwapListIdexes(List<string> enterList, int indexOne, int indexTwo)
        {
            List<string> resultList = enterList.ToList();
            string temp = resultList[indexOne];
            resultList[indexOne] = resultList[indexTwo];
            resultList[indexTwo] = temp;
            return resultList;
        }
    }
}
