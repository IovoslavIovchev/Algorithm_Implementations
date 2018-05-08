using System;

namespace Quicksort
{
    class Program
    {
        static void Main()
        {
            double[] unsortedArray = { 4, 1, -8.2, 2, 12, 18, 3.14, -23, -8.1, 1001 };

            Console.WriteLine($"Unsorted: {string.Join(" ", unsortedArray)}");

            Quicksort(unsortedArray, 0, unsortedArray.Length - 1);

            Console.WriteLine($"Sorted: {string.Join(" ", unsortedArray)}");
            Console.WriteLine();

            char[] unsortedLetters = { 'g', 'r', 's', 'a', 'm', 'z', 'x', 'u', 'v', 'b' };

            Console.WriteLine($"Unsorted: {string.Join(" ", unsortedLetters)}");

            Quicksort(unsortedLetters, 0, unsortedLetters.Length - 1);

            Console.WriteLine($"Sorted: {string.Join(" ", unsortedLetters)}");
        }

        static void Quicksort<T>(T[] array, int low, int high) where T : IComparable<T>
        {
            if (low < high)
            {
                int partitionIndex = PartitionIndex(array, low, high);

                Quicksort(array, low, partitionIndex - 1);
                Quicksort(array, partitionIndex + 1, high);
            }
        }

        static int PartitionIndex<T>(T[] array, int low, int high) where T : IComparable<T>
        {
            T pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j].CompareTo(pivot) < 1)
                {
                    ++i;
                    if (i != j) Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }

        static void Swap<T>(T[] array, int A, int B)
        {
            T temp = array[A];
            array[A] = array[B];
            array[B] = temp; 
        }
    }
}
