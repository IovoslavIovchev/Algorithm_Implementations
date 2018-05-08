using System;
using System.Diagnostics;

namespace Binary_Search
{
    class Program
    {
        static void Main()
        {
            int[] sortedArray = { -100, 3, 5, 7, 12, 34, 35, 36, 90, 101, 102, 103 };

            int num = 102;

            int position = Search(num, sortedArray, 0, sortedArray.Length - 1); 
            Console.WriteLine(position); //10

            char[] sortedLetters = { 'a', 'c', 'f', 'g', 'h', 'l', 'o', 'q', 's', 't', 'w', 'z' };

            char letter = 'm';

            position = Search(letter, sortedLetters, 0, sortedLetters.Length - 1);
            Console.WriteLine(position); //-1
        }

        //returns index of num in sortedArray or -1 if it isn't contained
        static int Search<T>(T itemToSearch, T[] array, int start, int end) where T : IComparable<T>
        {
            
            if ((end - start <= 1 && array[start].CompareTo(itemToSearch) != 0 && array[end].CompareTo(itemToSearch) != 0) || 
                itemToSearch.CompareTo(array[0]) < 0|| itemToSearch.CompareTo(array[array.Length-1]) > 0)
            {
                return -1;
            }

            int mid = (start + end) / 2;
                        
            if (itemToSearch.CompareTo(array[mid]) == 0)
            {
                return mid;
            }
            else if (itemToSearch.CompareTo(array[mid]) < 1)
            {
                return Search(itemToSearch, array, start, mid - 1);
            }
            else
            {
                return Search(itemToSearch, array, mid + 1, end);
            }
        }
    }
}
