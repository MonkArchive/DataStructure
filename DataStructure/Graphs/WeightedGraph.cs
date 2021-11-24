namespace Graphs
{
    public class WeightedGraph : Graph, IWeightedGraph
    {
        public WeightedGraph(int NVertex) : base(NVertex) { }

        public virtual void AddEdge(string x, string y, int w)
        {
            throw new System.NotImplementedException();
        }

        public virtual int GetEdgeWeight(string x, string y)
        {
            throw new System.NotImplementedException();
        }

        public virtual void SetEdgeWeight(string x, string y, int w)
        {
            throw new System.NotImplementedException();
        }

        public virtual int ShortestWeightPath(string x, string y)
        {
            throw new System.NotImplementedException();
        }
    }
}
