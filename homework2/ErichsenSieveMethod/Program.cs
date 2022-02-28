using System;

namespace ErichsenSieveMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            ErichsenSieve(num);
            static void ErichsenSieve(int y)
            {
                bool[] isPrime=new bool[y+1];
                isPrime[0] = false;
                isPrime[1] = false;

                for(int i = 2; i <= y; i++)
                {
                    isPrime[i] = true;
                }
                for(int i = 2; i <= y; i++)
                {
                    if (isPrime[i])
                    {
                        Console.WriteLine(i);
                        for (int j = 2 * i; j <= y; j += i)
                        {
                            isPrime[j] = false;
                        }
                    }
                   
                }
                
            }
            
        }
    }
}
