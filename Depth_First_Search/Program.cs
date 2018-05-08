using System;
using System.Diagnostics;

namespace Depth_First_Search
{
    class Program
    {
        //A STANDARD 5X5 MATRICE
        static int[,] matrix = {
            {3, 4, 1, 5, 1},
            {5, 5, 3, 5, 3},
            {0, 7, 5, 5, 3},
            {5, 5, 5, 5, 3},
            {0, 5, 0, 5, 4}
        };

        static bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

        static int temp = 0;
        static int maxTimes = 0;
        static int maxNum = 0;
        static Stopwatch sw = new Stopwatch();
        
        static void Main(string[] args)
        {
            sw.Start();
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    temp = 0;

                    if (!visited[x, y])
                        DFS(x, y, matrix[x, y]);
                }
            }

            Console.WriteLine("Most repeated number: {0} - {1} times", maxNum, maxTimes);
            sw.Stop();

            Console.WriteLine("Operation done in {0}ms", sw.ElapsedMilliseconds.ToString());
        }

        static void DFS(int x, int y, int N)
        {
            if (x < 0 || x >= matrix.GetLength(0) || y < 0 || y >= matrix.GetLength(1))
                return;
            if (visited[x, y])
                return;
            if (matrix[x, y] != N)
                return;

            temp++;
            visited[x, y] = true;

            if (temp > maxTimes)
            {
                maxTimes = temp;
                maxNum = N;
            }

            DFS(x - 1, y, N);
            DFS(x + 1, y, N);
            DFS(x, y - 1, N);
            DFS(x, y + 1, N);
        }
    }
}
