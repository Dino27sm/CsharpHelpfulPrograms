using System;

namespace IndexRotateToRight
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
            Console.Write("Positions to move Right: ");
            int indexMoveRight = int.Parse(Console.ReadLine());
            //---------- Find new index location -------------------------
            indexMoveRight %= initialArray.Length;
            int newIndex = (startIndex + indexMoveRight) % initialArray.Length;
            Console.WriteLine($"Element at New Index: {initialArray[newIndex]}");
        }
    }
}
