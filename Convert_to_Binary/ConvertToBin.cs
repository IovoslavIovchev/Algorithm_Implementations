using System;
using System.Text;

namespace Convert_to_Binary
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(Bin(long.Parse(Console.ReadLine())));
        }

        static string Bin(long n)
        {
            StringBuilder result = new StringBuilder();
            while (n > 0)
            {
                result.Insert(0, (n % 2).ToString());
                n /= 2;
            }
            return result.ToString();
        }
    }
}