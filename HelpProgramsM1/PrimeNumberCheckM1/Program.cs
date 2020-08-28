using System;

namespace PrimeNumberCheckM1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            int numCheck;
            while(!int.TryParse(Console.ReadLine(), out numCheck))
            {
                Console.Write("Enter an integer number:  ");
            }
            Console.WriteLine($"Prime numbers up to {numCheck}:");
            Console.WriteLine();
            for (int i = 2; i <= numCheck; i++)
            {
                if (IsPrimeNumberM3(i)) Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        //---- Faster Method to check if a number is a Prime one, using (6k ± 1) optmization-----
        static bool IsPrimeNumberM3(int inpNum) // For a Prime number returns "True"
        {
            if (inpNum <= 1)
            {
                Console.WriteLine("Enter a number greater than 1 !");
                return false;
            }
            int maxCount = (int)Math.Ceiling(Math.Sqrt(inpNum));
            if (inpNum == 2 || inpNum == 3) return true;
            else if (inpNum % 2 == 0 || inpNum % 3 == 0) return false;
            else if (inpNum < 25)
            {
                for (int i = 3; i <= maxCount; i += 2)
                    if (inpNum % i == 0) return false;
            }
            else
            {
                for (int k = 1; (6 * k - 1) <= maxCount; k++)
                    if (inpNum % (6 * k - 1) == 0 || inpNum % (6 * k + 1) == 0) return false;
            }
            return true;
        }
    }
}
