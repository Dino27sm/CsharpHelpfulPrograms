using System;
using System.Collections.Generic;
using System.Linq;

namespace RotateArrayClockwise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inpArray = Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int rotateItems = int.Parse(Console.ReadLine());
            rotateItems %= inpArray.Count;
            if (rotateItems != 0)
            {
                while (rotateItems > 0)
                {
                    inpArray.Insert(0, inpArray[inpArray.Count - 1]);
                    inpArray.RemoveAt(inpArray.Count - 1);
                    rotateItems--;
                }
            }
            Console.WriteLine(string.Join(" ", inpArray));
        }
    }
}
