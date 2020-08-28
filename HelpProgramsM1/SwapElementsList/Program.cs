using System;
using System.Collections.Generic;
using System.Linq;

namespace SwapElementsList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inpList = new List<string>() { "0", "1", "2", "3", "4", "5", "6" };
            List<string> printList = SwapListElements(inpList, "2", "3");
            Console.WriteLine(string.Join(" ", printList));
        }
        static List<string> SwapListElements(List<string> enterList, string itemOne, string itemTwo)
        {
            List<string> resultList = enterList.ToList();
            int indexOne = resultList.IndexOf(itemOne);
            int indexTwo = resultList.IndexOf(itemTwo);
            resultList[indexOne] = itemTwo;
            resultList[indexTwo] = itemOne;
            return resultList;
        }
    }
}
