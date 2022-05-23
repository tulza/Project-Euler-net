using System;

namespace P1_Mutiples_of_3_or_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mutiples of 3 or 5 (Problem 1)
            //https://projecteuler.net/problem=1

            //summery
            //find the sum total of 3 or 5 up to 1000

            int sum = 0;
            for (int i = 0; i * 3 < 1000;i++)
            {
                sum += i*3;
            }
            for (int i = 0; i * 5 < 1000; i++)
            {
                sum += i * 5;
            }
            //question asked for mutiple for 3 or 5 therefor cannot has dupe
            //lowest common factor is 15
            for (int i = 0; i*15 <  1000; i++)
            {
                sum -= i * 15;
            }
            Console.WriteLine(sum);
            // result 233168 (correct) 22/05/22

            //improvement
            int sum2 = Calc(3) + Calc(5) - Calc(15);
            Console.WriteLine(sum2);
            //or  Console.WriteLine(Calc(3) + Calc(5) - Calc(15));

            static int Calc( int mutiple) 
            {
                int sum = 0;
                for (int i = 0; i*mutiple < 1000; i++)
                {
                    sum += i * mutiple;
                }
                return sum;
            }

            // result 233168 (correct) 22/05/22
        }
    }
}
