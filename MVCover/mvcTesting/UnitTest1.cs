using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCover;
using QuickGraph;
using QuickGraph.Algorithms;

namespace mvcTesting
{
    [TestClass]
    public class UnitTest1
    {
        /*
         [TestMethod]
         public void TestMethod1()
         {
             UndirectedGraph<string, Edge<string>> graph = new UndirectedGraph<string, Edge<string>>(true);
             graph.AddVertex("1");
             graph.AddVertex("2");
             graph.AddVertex("3");
             graph.AddVertex("4");
             graph.AddVertex("5");
             graph.AddVertex("6");


             var edge12 = new Edge<string>("1", "2");
             var edge34 = new Edge<string>("3", "4");
             var edge24 = new Edge<string>("2", "4");
             var edge14 = new Edge<string>("1", "4");
             var edge16 = new Edge<string>("1", "6");
             var edge56 = new Edge<string>("5", "6");

             graph.AddEdge(edge12);
             graph.AddEdge(edge34);
             graph.AddEdge(edge24);
             graph.AddEdge(edge14);
             graph.AddEdge(edge16);
             graph.AddEdge(edge56);

             MVCcl mvc = new MVCcl(graph);
             mvc.minimumVertexCover();
             //Console.WriteLine(mvc.isMVCover().ToString());
             Assert.AreEqual(mvc.isMVCover(), true);

         }
        
         [TestMethod]
         public void TestMethod2()
         {
             UndirectedGraph<string, Edge<string>> graph = new UndirectedGraph<string, Edge<string>>(true);
             graph.AddVertex("1");
             graph.AddVertex("2");
             graph.AddVertex("3");
             graph.AddVertex("4");
             graph.AddVertex("5");
             graph.AddVertex("6");
             graph.AddVertex("7");
             graph.AddVertex("8");
             graph.AddVertex("9");
             graph.AddVertex("10");
             graph.AddVertex("11");
             graph.AddVertex("12");

             var edge17 = new Edge<string>("1", "7");
             var edge34 = new Edge<string>("3", "4");
             var edge24 = new Edge<string>("2", "4");
             var edge14 = new Edge<string>("1", "4");
             var edge16 = new Edge<string>("1", "6");
             var edge56 = new Edge<string>("5", "6");
             var edge67 = new Edge<string>("6", "7");
             var edge18 = new Edge<string>("1", "8");
             var edge19 = new Edge<string>("1", "9");
             var edge1_10 = new Edge<string>("1", "10");
             var edge1_11 = new Edge<string>("1", "11");
             var edge2_12 = new Edge<string>("2", "12");
             var edge28 = new Edge<string>("2", "8");
             var edge9_12 = new Edge<string>("9", "12");
             var edge4_11 = new Edge<string>("4", "11");
             var edge49 = new Edge<string>("4", "9");
             var edge5_10 = new Edge<string>("5", "10");
             var edge57 = new Edge<string>("5", "7");

             graph.AddEdge(edge17);
             graph.AddEdge(edge34);
             graph.AddEdge(edge24);
             graph.AddEdge(edge14);
             graph.AddEdge(edge16);
             graph.AddEdge(edge56);
             graph.AddEdge(edge67);
             graph.AddEdge(edge18);
             graph.AddEdge(edge19);
             graph.AddEdge(edge1_10);
             graph.AddEdge(edge1_11);
             graph.AddEdge(edge2_12);
             graph.AddEdge(edge28);
             graph.AddEdge(edge9_12);
             graph.AddEdge(edge4_11);
             graph.AddEdge(edge49);
             graph.AddEdge(edge5_10);
             graph.AddEdge(edge57);
             MVCcl mvc = new MVCcl(graph);
             mvc.minimumVertexCover();
             //Console.WriteLine(mvc.isMVCover().ToString());
             Assert.AreEqual(mvc.isMVCover(), true);

         }
        
         [TestMethod]
         public void TestMethod3()
         {
             UndirectedGraph<string, Edge<string>> graph = new UndirectedGraph<string, Edge<string>>(true);
             MVCcl mvc = new MVCcl(graph);
             mvc.generate(10);
             mvc.minimumVertexCover();
             //Console.WriteLine(mvc.isMVCover().ToString());
             Assert.AreEqual(mvc.isMVCover(), true);
         }
         */
        [TestMethod]
        public void TestMethod4()
        {
            UndirectedGraph<string, Edge<string>> graph = new UndirectedGraph<string, Edge<string>>(true);
            MVCcl mvc = new MVCcl(graph);
            mvc.generate(2000, 5);
            mvc.minimumVertexCover();
            //Console.WriteLine(mvc.isMVCover().ToString());
            //Assert.AreEqual(true, true);
            Assert.AreEqual(mvc.isMVCover(), true);
        }
    }
}
