using System;

namespace Reverse_Number
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int reversed = 0;

            while (n > 0)
            {
                int temp = n % 10;
                reversed = reversed * 10 + temp;
                n /= 10;
            }

            Console.WriteLine(reversed);
        }
    }
}
