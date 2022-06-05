using System;

namespace P9_Special_Pythagorean_triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Special Pythagorean triplet (Problem 9)
            //https://projecteuler.net/problem=9

            //A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
            //a2 + b2 = c2
            //For example, 32 + 42 = 9 + 16 = 25 = 52.
            //There exists exactly one Pythagorean triplet for which a +b + c = 1000.
            //Find the product abc.

            //summery
            //find product abc

            //a^2 + b^2 = c^2
            //a+b+c=1000, 
            // c >333

            for (long c = 1000; c > 333; c--)
            {

                long b = 1000 - c;
                for (int a = 1; a < b; a++)
                {
                    b--;
                    Console.WriteLine($"{a} {b} {c}");

                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                    {
                        Console.WriteLine($"{a} {b} {c}");
                        Console.ReadKey();
                        //result:
                        //200 375 425, abc = 31875000 (correct) 24/05/22
                    }
                }

            }

            /*
            if (a < b && b < c && a + b + c == 1000 && (a ^ 2 + b ^ 2 - c ^ 2) == 0)
            {
                Console.WriteLine($"{a} {b} {c}");
            }*/


        }
    }
}
