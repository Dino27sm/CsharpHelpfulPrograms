using System;

namespace IndexRotateToLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Strig array: ");
            string[] initialArray = Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
            Console.Write("Enter Start index: ");
            int startIndex = int.Parse(Console.ReadLine());
            Console.Write("Positions to move Left: ");
            int indexMoveLeft = int.Parse(Console.ReadLine());
            //---------- Find new index location -------------------------
            indexMoveLeft %= initialArray.Length;
            int newIndex = (initialArray.Length + (startIndex - indexMoveLeft)) % initialArray.Length;
            Console.WriteLine($"Element at New Index: {initialArray[newIndex]}");
        }
    }
}
