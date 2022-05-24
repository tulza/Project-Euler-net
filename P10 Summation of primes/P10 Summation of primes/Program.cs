using System;

namespace P10_Summation_of_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Summation of primes (Problem 10)
            //https://projecteuler.net/problem=10

            //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
            //the sum of all the primes below two million.

            //summery
            //find the sum of all prime under 2 million

            long sum = 0, max = 2000000; //2 million

            //start at 2 add by one then + 2 onward as even number has 2 as a mutiple
            for (long i = 2; i < max; i+=2)
            {
                if (i == 2)
                {
                    sum += 2;
                    i++;
                }

                if (IsPrime(i))
                {
                    //checking and summing up
                    Console.WriteLine($"{i} {sum}");
                    sum += i;
                }
            }
            Console.WriteLine("the sum is!");
            Console.WriteLine(sum);
            //result:
            //142913828922 (correct) 24/05/22

            //method of finding if prime
            static bool IsPrime(long num)
            {
                for (int i = 3; i < (int)num/2; i+=2)
                {
                    if (num%i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
