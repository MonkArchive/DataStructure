using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(5);

            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");
            graph.AddVertex("E");

            graph.AddEdge("A", "B");
            graph.AddEdge("A", "C");
            graph.AddEdge("B", "D");
            graph.AddEdge("C", "D");
            graph.AddEdge("C", "E");
            graph.AddEdge("D", "E");

            Console.WriteLine(graph.Adjacent("B", "D"));
            Console.WriteLine(graph.Adjacent("B", "E"));

            var neighbors = graph.Neighbors("D");
        }
    }
}
