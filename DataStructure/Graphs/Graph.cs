using System;

namespace Graphs
{
    public class Graph : IGraph
    {
        protected readonly int _nVertex;
        protected string[] _vertices;
        protected int[,] _adMatrix;

        public Graph(int NVertex)
        {
            _nVertex = NVertex;
            _adMatrix = new int[NVertex, NVertex];
            _vertices = new string[NVertex];

            IntializeGraph();
        }

        public virtual void AddEdge(string x, string y)
        {
            var indexX = GetVertexIndex(x);
            var indexY = GetVertexIndex(y);

            // 1 Means Edge Exists; MinInt Means Edge Doesn't Exist
            _adMatrix[indexX, indexY] = 1;
            _adMatrix[indexY, indexX] = 1; // Skip This In Directed Graph
        }

        protected int GetVertexIndex(string x)
        {
            int i;

            for (i = 0; i < _nVertex && _vertices[i] != x; i++) ;

            if (i == _nVertex)
                throw new Exception("Invalid Vertex");

            return i;
        }

        public virtual void AddVertex(string x)
        {
            int i;

            for (i = 0; i < _nVertex && _vertices[i] != null; i++) ;

            if (i == _nVertex)
                throw new Exception("Cannot Add Any More Vertex");
            else
                _vertices[i] = x;
        }

        public virtual bool Adjacent(string x, string y)
        {
            var indexX = GetVertexIndex(x);
            var indexY = GetVertexIndex(y);

            return _adMatrix[indexX, indexY] == 1;
        }

        public virtual void BreadthFirstSearch()
        {
            throw new NotImplementedException();
        }

        public virtual void DepthFirstSearch()
        {
            throw new NotImplementedException();
        }

        public virtual string[] Neighbors(string x)
        {
            var result = new string[_nVertex];
            var neighbors = 0;

            var indexX = GetVertexIndex(x);

            for (int i = 0; i < _nVertex; i++)
                if (_adMatrix[indexX, i] == 1)
                    result[neighbors++] = _vertices[i];

            return result;
        }

        public virtual void RemoveEdge(string x, string y)
        {
            var indexX = GetVertexIndex(x);
            var indexY = GetVertexIndex(y);

            // 1 Means Edge Exists; MinInt Means Edge Doesn't Exist
            _adMatrix[indexX, indexY] = Int32.MinValue;
            _adMatrix[indexY, indexX] = Int32.MinValue; // Skip This In Directed Graph
        }

        public virtual void RemoveVertex(string x)
        {
            var indexX = GetVertexIndex(x);

            _vertices[indexX] = null;

            for (int i = 0; i < _nVertex; i++)
            {
                _adMatrix[indexX, i] = Int32.MinValue;
                _adMatrix[i, indexX] = Int32.MinValue;
            }
        }

        public virtual int ShortestPath(string x, string y)
        {
            throw new NotImplementedException();
        }

        protected virtual void IntializeGraph()
        {
            for (int i = 0; i < _nVertex; i++)
                for (int j = 0; j < _nVertex; j++)
                    _adMatrix[i, j] = Int32.MinValue;
        }

    }
}
