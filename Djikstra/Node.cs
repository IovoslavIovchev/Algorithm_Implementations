using System;
using System.Collections.Generic;
using System.Text;

namespace Djikstra
{
    public class Node : IComparable<Node>
    {
        public int Value { get; set; }

        public long BestPath { get; set; }

        public bool Visited { get; set; }

        public Node Previous { get; set; }

        public Dictionary<int, long> Children { get; set; } //<child, distanceToChild>

        public int CompareTo(Node other)
        {
            return this.BestPath.CompareTo(other.BestPath) == 0 ? 
                this.Value.CompareTo(other.Value) : this.BestPath.CompareTo(other.BestPath);
        }
    }
}
