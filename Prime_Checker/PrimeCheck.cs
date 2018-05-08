using System;
using System.Collections.Generic;

namespace Prime_Checker_in_Range
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine()); //start of the range
            int end = int.Parse(Console.ReadLine()); //end of the range

            List<int> primes = new List<int>();

            for (int i = start; i <= end; i++)
            {
                int ctrl = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        ctrl++;
                        break;
                    }
                }

                if (ctrl == 0 && i != 1)
                {
                    primes.Add(i);
                }
            }

            foreach (var prime in primes)
            {
                Console.WriteLine(prime);
            }
        }
    }
}
