using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexCoverWinForms
{
    class MyGraph
    {
        private List<Vertex> _V = new List<Vertex>();
        private List<Edge> _E = new List<Edge>();

        private int _iteration;

        public List<Edge> Edges
        {
            get { return _E; }
        }

        public List<Vertex> Vertices
        {
            get { return _V; }
        }

        public int Iteration
        {
            get { return _iteration; }
        }

        public MyGraph()
        {

        }

       public MyGraph(string text)
        {
            text = text.Replace("\r", "");
            string[] paragraph = text.Split("\n", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < paragraph.Length; i++)
            {
                Vertex temp = new Vertex(i + 1);
                this.AddVertex(temp);
            }

            for (int i = 0; i < paragraph.Length; i++)
            {

                string[] vecNumbers = paragraph[i].Substring(paragraph[i].IndexOf(":") + 1).Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < vecNumbers.Length; j++)
                {
                    this.AddEdge(_V[i], _V[Convert.ToInt32(vecNumbers[j]) - 1]);
                }
            }

            for (int i = 0; i < _E.Count; i++)
            {
                _E.RemoveAll(x => x.FromVert == _E[i].ToVert && x.ToVert == _E[i].FromVert);
            }

        }

        public void AddVertex(Vertex vertex)
        {
            _V.Add(vertex);
        }

        public void AddEdge(Vertex v1, Vertex v2)
        {
            if (!_V[_V.IndexOf(v1)]._E.Exists(x => x.FromVert == v1 && x.ToVert == v2))
            {
                Edge edge = new Edge(v1, v2);
                _E.Add(edge);

                _V[_V.IndexOf(v1)].AddEdge(edge);
            }

            if (!_V[_V.IndexOf(v2)]._E.Exists(x => x.ToVert == v1))
            {
                Edge edge2 = new Edge(v2, v1);
                _V[_V.IndexOf(v2)].AddEdge(edge2);
            }
            
        }

        private Vertex GetMaxVertex(List<Vertex> vertices)
        {
            Vertex result = vertices[0];

            for (int i = 1; i < vertices.Count; i++)
            {
                if (result.GetCountEdges() <= vertices[i].GetCountEdges())
                {
                    result = vertices[i];
                }
            }

            return result;
        }

        public List<Vertex> VertexCover_Greedy()
        {
            _iteration = 0;
            List<Vertex> temp_V = new List<Vertex>();
            List<Edge> temp_E = new List<Edge>();
            temp_V.AddRange(_V);
            temp_E.AddRange(_E);

            List<Vertex> result = new List<Vertex>();

            while (temp_E.Count != 0)
            {
                Vertex max_vertex = GetMaxVertex(temp_V);

                temp_E.RemoveAll(edge => edge.FromVert == max_vertex);
                temp_E.RemoveAll(edge => edge.ToVert == max_vertex);

                result.Add(max_vertex);
                temp_V.Remove(max_vertex);

                _iteration++;
            }

            return result;
        }

        public List<Vertex> VertexCover_Approx()
        {
            _iteration = 0;
            List<Vertex> result = new List<Vertex>();

            List<Edge> temp_E = new List<Edge>();
            temp_E.AddRange(_E);

            while (temp_E.Count != 0)
            {
                var randEdge = temp_E[new Random().Next(0, temp_E.Count - 1)];

                temp_E.RemoveAll(edge => edge.FromVert == randEdge.FromVert);
                temp_E.RemoveAll(edge => edge.ToVert == randEdge.FromVert);

                temp_E.RemoveAll(edge => edge.FromVert == randEdge.ToVert);
                temp_E.RemoveAll(edge => edge.ToVert == randEdge.ToVert);

                result.Add(randEdge.ToVert);
                result.Add(randEdge.FromVert);
                _iteration++;
            }



            return result;
        }
    }
}
