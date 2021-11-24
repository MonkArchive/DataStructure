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

        public virtual int ShortestWeightPath(string x, string y)
        {
            throw new System.NotImplementedException();
        }
    }
}
