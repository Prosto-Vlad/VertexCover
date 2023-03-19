using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VertexCoverWinForms
{
    class Vertex
    {
        private int _number;
        public List<Edge> _E = new List<Edge>();

        public int Number
        {
            get { return _number; }
        }

        public Vertex()
        {
        }

        public Vertex(int num)
        {
            _number = num;
        }

        public void AddEdge(Edge edge)
        {
            _E.Add(edge);
        }

        public int GetCountEdges()
        {
            return _E.Count;
        }
    }
}
