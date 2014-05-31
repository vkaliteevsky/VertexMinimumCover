using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickGraph.Data;
using QuickGraph.Graphviz;
using QuickGraph.Algorithms;
using QuickGraph.Collections;
using QuickGraph.Contracts;
using QuickGraph.Predicates;
using QuickGraph.Serialization;
using QuickGraph;

//using System.Collections;
using System.Diagnostics;


using QuickGraph.Collections;
using QuickGraph.Predicates;



namespace MVCover
{
    public class MVCcl
    {
        public UndirectedGraph<string, Edge<string>> mOldGraph;
        public UndirectedGraph<string, Edge<string>> mGraph;
        public List<string> mCover;
        Random randObj = new Random(0);
        Random rng = new Random();
        public MVCcl(UndirectedGraph<string, Edge<string>> _mGraph)
        {
            mGraph = _mGraph;
            mOldGraph = new UndirectedGraph<string, Edge<string>>(true);
            mCover = new List<string>();
            
            List<Edge<string>> list = new List<Edge<string>>(mGraph.Edges);

            foreach (string vertex in mGraph.Vertices)
            {
                mOldGraph.AddVertex(vertex);
            }

            for (int i = 0; i < list.Count; i++)
            {
                mOldGraph.AddEdge(list[i]);
            }
        }

        public void minimumVertexCover()
        {
            while (!mGraph.IsEdgesEmpty)
            {
                MVCIteration();
            }
        }

        public void MVCIteration()
        {

            List<Edge<string>> edgesToDel = new List<Edge<string>>();

            int count = mGraph.EdgeCount;
            int rand = rng.Next(count-1);

            List<Edge<string>> list = new List<Edge<string>>(mGraph.Edges);
            Edge<string> edge1 = list[rand];
            this.mCover.Add(edge1.Source);
            this.mCover.Add(edge1.Target);
            mGraph.RemoveEdge(edge1);

            for (int i = 0; i < mGraph.EdgeCount; i++)
            {
                if (mGraph.Edges.ElementAt(i).IsAdjacent(edge1.Source))
                {
                    edgesToDel.Add(mGraph.Edges.ElementAt(i));
                }
                if (mGraph.Edges.ElementAt(i).IsAdjacent(edge1.Target))
                {
                    edgesToDel.Add(mGraph.Edges.ElementAt(i));
                }
            }

            foreach (Edge<string> edge in edgesToDel)
            {
                if (mGraph.ContainsEdge(edge))
                {
                    mGraph.RemoveEdge(edge);
                }
            }
        }

        public bool isMVCover(UndirectedGraph<string, Edge<string>> graph, List<string> cover)
        {
            foreach (Edge<string> edge in graph.Edges)
            {
                foreach (string ver in cover)
                {
                    if (!edge.IsAdjacent(ver))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool isMVCover()
        {
            bool ret = true;
            foreach (Edge<string> edge in mOldGraph.Edges)
            {
                ret = false;
                foreach (string ver in mCover)
                {
                    if (edge.IsAdjacent(ver))
                    {
                        ret = true;                    
                    }
                }
                if (ret == false)
                {
                    return false;
                }
            }
            return true;
        }

        public void generate(int count, int coeff) 
        {
            mGraph = new UndirectedGraph<string, Edge<string>>(true);

            for (int i = 0; i < count; i++)
            {
                mGraph.AddVertex(i.ToString());
            }

            for (int i = 0; i < count * coeff; i++)
            {
                int rand = rng.Next(count - 1);
                int rand2 = rng.Next(count - 1);
                var edge12 = new Edge<string>(rand.ToString(), rand2.ToString());
                mGraph.AddEdge(edge12);
            }

            mOldGraph = new UndirectedGraph<string, Edge<string>>(true);
            mCover = new List<string>();

            List<Edge<string>> list = new List<Edge<string>>(mGraph.Edges);

            foreach (string vertex in mGraph.Vertices)
            {
                mOldGraph.AddVertex(vertex);
            }

            for (int i = 0; i < list.Count; i++)
            {
                mOldGraph.AddEdge(list[i]);
            }
        }
    }
}
