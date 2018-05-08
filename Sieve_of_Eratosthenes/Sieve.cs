using System;
using System.Collections.Generic;
using System.Linq;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main()
        {
            Console.Write("Find all primes in the range 2..N.\nEnter N: ");
            long num = long.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("No prime numbers");
                return;
            }

            bool[] primes = new bool[num + 1].Select(x => x = true).ToArray();

            Sieve(num, primes);

            for (int i = 2; i <= num; i++)
            {
                if (primes[i])
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Sieve(long N, bool[] primes)
        {
            for (int i = 2; i * i <= N; i++)
            {
                if (primes[i])
                {
                    for (int j = i * 2; j <= N; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }
        }
    }
}
