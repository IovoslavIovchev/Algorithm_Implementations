using System;
using System.Collections.Generic;
using System.Text;
using Wintellect.PowerCollections;

namespace Djikstra
{
    class Program
    {
        static Dictionary<int, Node> graph;

        static void Main()
        {
            InitializeGraph();

            Djisktra();

            // Print shortest path to Node 5 
            PrintPath(5);
        }

        private static void Djisktra()
        {
            OrderedBag<Node> priorityQueue = new OrderedBag<Node>();
            graph[1].BestPath = 0;
            priorityQueue.Add(graph[1]);

            while (priorityQueue.Count > 0)
            {
                Node tempNode = priorityQueue.RemoveFirst();
                tempNode.Visited = true;

                foreach (int child in tempNode.Children.Keys)
                {
                    if (graph[child].Visited) continue;

                    long currentBestPath = tempNode.Children[child] + tempNode.BestPath;

                    if (currentBestPath < graph[child].BestPath)
                    {
                        priorityQueue.Remove(graph[child]);

                        graph[child].BestPath = currentBestPath;
                        graph[child].Previous = tempNode;

                        priorityQueue.Add(graph[child]);
                    }
                }
            }
        }

        private static void PrintPath(int nodeValue)
        {
            Node node = graph[nodeValue];
            Stack<Node> stack = new Stack<Node>();
            stack.Push(node);

            node = node.Previous;
            while (node != null)
            {
                stack.Push(node);
                node = node.Previous;
            }

            StringBuilder path = new StringBuilder();
            while (stack.Count > 0)
            {
                path.Append($"{stack.Pop().Value} -> ");
            }
            path.Remove(path.Length - 4, 4);

            Console.WriteLine(path);
        }

        // Initialize Graph with Wikipedia Example values
        private static void InitializeGraph()
        {
            graph = new Dictionary<int, Node>();

            graph.Add(1, new Node()
            {
                Value = 1,
                BestPath = long.MaxValue,
                Children = new Dictionary<int, long>()
                {
                    { 2, 7 },
                    { 3, 9 },
                    { 6, 14 }
                }
            });

            graph.Add(2, new Node()
            {
                Value = 2,
                BestPath = long.MaxValue,
                Children = new Dictionary<int, long>()
                {
                    { 1, 7 },
                    { 3, 10 },
                    { 4, 15 }
                }
            });

            graph.Add(3, new Node()
            {
                Value = 3,
                BestPath = long.MaxValue,
                Children = new Dictionary<int, long>()
                {
                    { 1, 9 },
                    { 2, 10 },
                    { 4, 11 },
                    { 6, 2 }
                }
            });

            graph.Add(4, new Node()
            {
                Value = 4,
                BestPath = long.MaxValue,
                Children = new Dictionary<int, long>()
                {
                    { 2, 15 },
                    { 3, 11 },
                    { 5, 6 }
                }
            });

            graph.Add(5, new Node()
            {
                Value = 5,
                BestPath = long.MaxValue,
                Children = new Dictionary<int, long>()
                {
                    { 4, 6 },
                    { 6, 9 }
                }
            });

            graph.Add(6, new Node()
            {
                Value = 6,
                BestPath = long.MaxValue,
                Children = new Dictionary<int, long>()
                {
                    { 1, 14 },
                    { 3, 2 },
                    { 5, 9 }
                }
            });
        }
    }
}
