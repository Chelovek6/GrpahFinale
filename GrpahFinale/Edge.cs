using System;
using System.Collections.Generic;
using System.Text;

namespace GrpahFinale
{
    class Edge
    {
        public int Source { get; }
        public int Destination { get; }
        public int Weight { get; }

        public Edge(int source, int destination, int weight)
        {
            Source = source;
            Destination = destination;
            Weight = weight;
        }
    }
}
