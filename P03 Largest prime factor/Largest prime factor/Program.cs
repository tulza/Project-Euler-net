using System;

namespace Largest_prime_factor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Largest prime factor (Problem 3)
            //https://projecteuler.net/problem=3

            //The prime factors of 13195 are 5, 7, 13 and 29.
            //What is the largest prime factor of the number 600851475143 ?

            //summery
            //find largest prime factor of 600851475143 

            long max = (long) 600851475143;

            for (int i = 1; i < (long)max /2; i+=2)
            {
                if (i % 5 != 0)
                {
                    if (IsPrime(i))
                    {
                        if (max%i == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
            //result:
            //1
            //71
            //839
            //1471
            //6857 (correct) 23/05/22
        }

        static bool IsPrime(long num)
        {

            if (num % 5 == 0)
            {
                return false;
            }
            for (int i = 3; i < (int)num/2; i+=2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
