using System;

namespace P7__10001st_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //10001st prime (Problem 7)
            //https://projecteuler.net/problem=7

            //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
            //What is the 10001st prime number ?

            //summery
            //find the what the 10001st prime digit is

            int PrimeCount = 0;
            for (int i = 2; PrimeCount != 10001; i+=2)
            {
                if (i == 2)
                {
                    PrimeCount++;
                    i++;
                }
                if (IsPrime(i))
                {
                    PrimeCount++;
                    Console.WriteLine($"{PrimeCount}) {i}");
                    //result
                    // 10001) 104743 (corrcet) 24/05/2022
                }
            }
        }

        private static bool IsPrime(int i)
        {
            //check for til half of i as number higher than half will always not double to i
            int max = (int)i / 2;
            for (int j = 3; j < max; j+=2)
            {
                //if i equal 3 return true
                if (j == i)
                {
                    return true;
                }
                //if i divide j and remainder is 0 return false
                if (i%j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
