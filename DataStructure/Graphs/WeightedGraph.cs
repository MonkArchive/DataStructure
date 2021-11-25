using System;

namespace Graphs
{
    public class WeightedGraph : Graph, IWeightedGraph
    {
        public WeightedGraph(int NVertex) : base(NVertex) { }

        public virtual void AddEdge(string x, string y, int w)
        {
            SetEdgeWeight(x, y, w);
        }

        public virtual int GetEdgeWeight(string x, string y)
        {
            var indexX = GetVertexIndex(x);
            var indexY = GetVertexIndex(y);

            return _adMatrix[indexX, indexY];
        }

        public virtual void SetEdgeWeight(string x, string y, int w)
        {
            var indexX = GetVertexIndex(x);
            var indexY = GetVertexIndex(y);

            // 1 Means Edge Exists; MinInt Means Edge Doesn't Exist
            _adMatrix[indexX, indexY] = w;
            _adMatrix[indexY, indexX] = w; // Skip This In Directed Graph
        }

        public virtual int ShortestPath(string x, string y)
        {
            int[,] distance = new int[_nVertex, _nVertex];
            var indexX = GetVertexIndex(x);
            var indexY = GetVertexIndex(y);

            // Initialize The Distance Matrix
            for (int i = 0; i < _nVertex; i++)
                for (int j = 0; j < _nVertex; j++)
                { 
                    distance[i, j] = _adMatrix[i, j] == Int32.MinValue
                        ? 1000000
                        : _adMatrix[i, j];

                    if (i == j)
                        distance[i, j] = 0;
                }

            // Find All The Shortest Paths In The Graph
            // Floyd Warshall Algorithm O(N^3)
            for (int k = 0; k < _nVertex; k++)
                for (int i = 0; i < _nVertex; i++)
                    for (int j = 0; j < _nVertex; j++)
                        if (distance[i, k] + distance [k, j] < distance [i, j])
                            distance [i, j] = distance[i, k] + distance[k, j];

            // Return Result
            return distance[indexX, indexY];
        }
    }
}
