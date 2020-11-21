using System;
using System.Collections;


namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<double> myList = new CustomList<double>();

            for (double count = 0.0; count < 10; count += 1.1)
            {
                myList.Add(count);
            }

            myList.RemoveAt(9);
            myList.InsertAt(2, 3);
            myList.Swap(0, 8);
            myList.Reverse();

            Console.WriteLine(myList.Count);
            Console.WriteLine(myList);
            Console.WriteLine(myList.Contains(6.6));
        }
    }
}
