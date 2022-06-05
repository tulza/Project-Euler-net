using System;

namespace P6_Sum_square_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum square difference (Problem 6)

            //The sum of the squares of the first ten natural numbers is,
            // 1^2 + 2^2 + ... + 10^2 = 385
            //The square of the sum of the first ten natural numbers is,
            // (1+2+...+10)^2 = 3025
            //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is .
            //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

            //summery
            //find difference between sum of first hundred natrual number for sum of square and square of sum

            double sumOS = 0;
            double SOSum = 0;

            for (int i = 0; i < 101; i++)
            {
                sumOS += Math.Pow(i,2);
            }

            double a = 0;
            for (int i = 0; i < 101; i++)
            {
                a += i;
            }
            SOSum = Math.Pow(a,2) ;

            Console.WriteLine(SOSum-sumOS);
            //result:
            //25164150 (correct) 23/05/22
        }
    }
}
