using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexCoverWinForms
{
    class Edge
    {
        private Vertex _from;
        public Vertex FromVert
        {
            get { return _from; }
        }

        private Vertex _to;
        public Vertex ToVert
        {
            get { return _to; }
        }

        public Edge(Vertex V1, Vertex V2)
        {
            _from = V1;
            _to = V2;
        }
    }
}
