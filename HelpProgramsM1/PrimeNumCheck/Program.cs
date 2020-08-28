using System;

namespace PrimeNumCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program checks if a number is a Prime Number. Checking is only
            // for dividers less than the  Square of the Number, becouse a Number cannot
            // contain more than one number greater than the Square(Num)

            int numberToCheck = int.Parse(Console.ReadLine());
            for (int i = 2; i <= numberToCheck; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static bool IsPrimeNumber(int inpNum) // For Prime number returns "True"
        {
            if (inpNum <= 1)
            {
                Console.WriteLine("Enter a number greater than zero !");
                return false;
            }
            int maxCount = (int)Math.Sqrt(inpNum);
            for (int i = 2; i <= maxCount; i++)
            {
                if (inpNum % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
