using System;
using System.Collections.Generic;
using System.Text;

namespace GrpahFinale
{
    class Graph
    {
        private int vertices; // Количество вершин в графе
        private List<Edge> edges; // Список ребер в графе

        public Graph(int v)
        {
            vertices = v;
            edges = new List<Edge>();
        }

        public void AddEdge(int source, int destination, int weight)
        {
            edges.Add(new Edge(source, destination, weight));
        }

        private int Find(int[] parent, int i)
        {
            if (parent[i] != i)
                parent[i] = Find(parent, parent[i]);

            return parent[i];
        }

        private void Union(int[] parent, int x, int y)
        {
            int xRoot = Find(parent, x);
            int yRoot = Find(parent, y);
            parent[xRoot] = yRoot;
        }

        public void KruskalMST()
        {
            List<Edge> result = new List<Edge>(); // Результат минимального остовного дерева

            // Сортировка ребер по возрастанию весов
            edges.Sort((x, y) => x.Weight.CompareTo(y.Weight));

            int[] parent = new int[vertices];

            for (int i = 0; i < vertices; i++)
                parent[i] = i;

            int edgeCount = 0;
            int edgeIndex = 0;

            while (edgeCount < vertices - 1)
            {
                Edge nextEdge = edges[edgeIndex++];
                int x = Find(parent, nextEdge.Source);
                int y = Find(parent, nextEdge.Destination);

                // Проверяем, приведет ли добавление данного ребра к циклу
                if (x != y)
                {
                    result.Add(nextEdge);
                    Union(parent, x, y);
                    edgeCount++;
                }
            }

            // Выводим результат
            Console.WriteLine("Минимальное остовное дерево:");
            foreach (Edge edge in result)
            {
                Console.WriteLine($"{edge.Source} -- {edge.Destination} \tВес: {edge.Weight}");
            }
        }
    }
}
