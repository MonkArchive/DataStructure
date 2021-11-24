namespace Graphs
{
    public interface IGraph
    {
        bool Adjacent(string x, string y);
        string[] Neighbors(string x);
        void AddVertex(string x);
        void RemoveVertex(string x);
        void AddEdge(string x, string y);
        void RemoveEdge(string x, string y);

        void BreadthFirstSearch();
        void DepthFirstSearch();

        int ShortestPath(string x, string y);
    }

    public interface IWeightedGraph : IGraph
    {
        void AddEdge(string x, string y, int w);
        int GetEdgeWeight(string x, string y);
        void SetEdgeWeight(string x, string y, int w);
        int ShortestWeightPath(string x, string y);
    }
}
