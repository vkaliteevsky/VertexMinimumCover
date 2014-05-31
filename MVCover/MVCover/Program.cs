using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickGraph;
using QuickGraph.Algorithms;

namespace MVCover
{
    class Program
    {
        static void Main(string[] args)
        {
            UndirectedGraph<string, Edge<string>> graph = new UndirectedGraph<string, Edge<string>>(true);

            MVCcl mvc = new MVCcl(graph);
            mvc.generate(10,2);
            mvc.minimumVertexCover();
            //MVCcl mvc = new MVCcl();
            //mvc.minimumVertexCover();
            //Console.WriteLine(mvc.isMVCover().ToString());
            //Console.WriteLine(String.Join(", ", mvc.mCover.ToArray()));
            //Console.ReadLine();
        }
    }
}
