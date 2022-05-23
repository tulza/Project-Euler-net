using System;
using System.Linq;

namespace Largest_palindrome_product
{
    class Program
    {
        static void Main(string[] args)
        {
            //Largest palindrome product (Problem 4)
            //https://projecteuler.net/problem=4

            //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2 - digit numbers is 9009 = 91 × 99.
            //Find the largest palindrome made from the product of two 3 - digit numbers.

            //summery
            //find  largest palindrome number made from two 3 digits number
            //example of palindrome: 9876789

            int ea = 0, eb = 0;
            int largestPali= 0;
            int c = 0; // optimization

            //brute force 
            for (int a = 1; a < 1000; a++)
            {
                for (int b = 1+c; b < 1000; b++)
                { 
                    if (IsPali(a * b))
                    {
                        if (a * b > largestPali)
                        {
                            largestPali = a * b;
                            ea = a;
                            eb = b;
                        }
                        Console.WriteLine($"{a*b} ({a},{b})");
                    }
                }
                c++;
            }
            Console.WriteLine("largest 3 digit palindrome is ");
            Console.WriteLine($"{largestPali} ({ea},{eb})");
            //result: 
            //906609 (913, 993) (correct) 23/05/22 - Ashton Jitsawatapaiboon


            static bool IsPali(int a)
            {
                int [] cr = a.ToString().Select(o => Convert.ToInt32(o)).ToArray();
                
                for (int i = 0; i < (int)cr.Length/2; i++)
                {
                    if (cr[i] != cr[cr.Length-i-1])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
