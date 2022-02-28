using System;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INPUT THE NUMBER");
            int num =int.Parse(Console.ReadLine());
            findPrimeFactors(num, 2);

            static void findPrimeFactors(int num, int i)
            {
                if (num != 1)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(i);
                        num = num / i;
                        findPrimeFactors(num, i);
                    }
                    else
                    {
                        i++;
                        findPrimeFactors(num, i);
                    }
                }
 
            }
        }
    }
}
