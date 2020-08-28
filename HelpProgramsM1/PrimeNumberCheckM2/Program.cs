using System;

namespace PrimeNumberCheckM2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCheck = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numCheck; i++)
            {
                if (IsPrimeNumberM2(i)) Console.Write($"{i} ");
            }

            //if (IsPrimeNumberM2(numCheck)) Console.WriteLine($"{numCheck} is a Prime num");
            //else Console.WriteLine($"{numCheck} is NOT a Prime num");
        }
        //------------- Faster Method to check if a number is a Prime one --------------------
        static bool IsPrimeNumberM2(int inpNum) // For Prime number returns "True"
        {
            if (inpNum <= 1) 
            {
                Console.WriteLine("Enter a number greater than zero !");
                return false;
            }
            int maxCount = (int)Math.Ceiling(Math.Sqrt(inpNum));
            if (inpNum == 2 || inpNum == 3) return true;
            else if (inpNum % 2 == 0 || inpNum % 3 == 0) return false;
            else
            {
                for (int i = 3; i <= maxCount; i += 2)
                {
                    if (inpNum % i == 0) return false;
                }
            }
            return true;
        }
    }
}
