using System;
using System.Linq;

namespace P5_Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Smallest multiple (Problem 5)
            //https://projecteuler.net/problem=5

            //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

            //summery find the lowest mutiple of number 1 to 20

            //clue:
            //the number must be even as divisible by 2, num individual int sum is divisible by 3
            // start of int must be at least 40 and we can check by 20 at a time as of largest mutiple

            long lowestint = 0;
            for (long i = 2520; ; i += 2520)
            {
                Console.WriteLine(i);
                if (IsToMutiple(i))
                {
                    lowestint = i;
                    break;
                }
            }
            
            Console.WriteLine(lowestint);
            //result:
            //232792560 (correct) 23/05/22
        }

        static bool IsToMutiple(long num)
        {
            //To mutiple minus 1
            for (int i = 1; i < 21; i++)
            {
                if (num%i != 0)
                {
                    Console.WriteLine(i);
                    return false;
                }
            }
            return true;
        }
    }
}
