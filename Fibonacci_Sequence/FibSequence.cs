using System;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); //N-th number in the Fibonacci Sequence

            int x = 0, y = 1, sum = 0;
            for (int i = 2; i <= N; i++)
            {
                sum = (x + y);
                x = y;
                y = sum;
            }

            Console.WriteLine(x);
        }
    }
}
