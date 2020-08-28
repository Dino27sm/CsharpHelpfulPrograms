using System;
using System.Linq;
using System.Collections.Generic;

namespace RotateArrayCounterClockwise
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
                    inpArray.Insert(inpArray.Count, inpArray[0]);
                    inpArray.RemoveAt(0);
                    rotateItems--;
                }
            }
            Console.WriteLine(string.Join(" ", inpArray));
        }
    }
}
