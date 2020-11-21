using System;
using System.Collections;


namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array1 = { 1, 2, 3 };
            //int[] array2 = new int[array1.Length * 2];

            CustomList myList = new CustomList();

            myList.Add(0);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Add(9);

            myList.RemoveAt(9);
            myList.InsertAt(2, 3);
            myList.Swap(0, 8);
            myList.Reverse();

            Console.WriteLine(myList.Count);
            Console.WriteLine(myList);
            Console.WriteLine(myList.Contains(6));
        }
    }
}
