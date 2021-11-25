using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            WeightedGraph graph = new WeightedGraph(5);

            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");
            graph.AddVertex("E");

            graph.AddEdge("A", "B", 20);
            graph.AddEdge("A", "C", 100);
            graph.AddEdge("B", "D", 40);
            graph.AddEdge("C", "D", 35);
            graph.AddEdge("C", "E", 27);
            graph.AddEdge("D", "E", 25);

            Console.WriteLine(
                $"Distance From A To E Is {graph.ShortestPath("A", "B")}");
        }
    }
}
