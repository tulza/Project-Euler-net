using System;

namespace count_of_total_1000_pp_by____
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] check = input.Split("sakamata1");
            int count = 0;
            foreach (var item in check)
            {
                    count++;
                    Console.WriteLine(item);
                
            }
            Console.WriteLine(count);
        }
    }
}
