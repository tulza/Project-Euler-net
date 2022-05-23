﻿using System;

namespace Even_Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Even Fibonacci numbers
            //Problem 2 at https://projecteuler.net/

            //each new term in the fibonacci sequence is generated by adding the previous two terms.
            //by starting with 1 and 2, the first 10 terms will be:
            //1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
            //by considering the terms in the fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

            //Find sum of Fibonacci under 4million for even value starting with 1 and 2

            long sum = 0;
            int max = 4000000; //4 million
            int a = 1, b = 2;  //start int
            for (int i = 0; a<max && b < max  ; i++)
            {
                Console.WriteLine($"{a} {b}");
                if (b%2 == 0)
                {
                    sum += b;
                }
                a += b;

                //swap values for easy calculation
                (a, b) = (b, a);
            }
            Console.WriteLine(sum);
        }
    }
}
