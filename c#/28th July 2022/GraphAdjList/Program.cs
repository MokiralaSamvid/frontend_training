using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAdjList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(6);
            g.AddEdge(0, 1, true);
            g.AddEdge(1, 2, true);
            g.AddEdge(2, 3, true);
            g.AddEdge(3, 4, true);
            g.AddEdge(4, 5, true);
            g.AddEdge(3, 5, true);
            g.AddEdge(4, 0, true);
            g.PrintGraph();
            Console.WriteLine("Output of BFS");
            g.BFS(0);
            Console.WriteLine("Output of DFS");
            g.DFS(0);
            Console.ReadLine();
            Console.Clear();

            Graph g2 = new Graph(7);
            g2.AddEdge(0, 1, true);
            g2.AddEdge(1, 2, true);
            g2.AddEdge(2, 3, true);
            g2.AddEdge(0, 4, true);
            g2.AddEdge(3, 4, true);
            g2.AddEdge(3,5,true);
            g2.AddEdge(4,5, true); 
            g2.AddEdge(5,6,true);
            g2.PrintGraph();
            Console.WriteLine("Output of BFS");
            g2.BFS(1);
            Console.WriteLine("Output of DFS");
            g2.DFS(1);
            Console.ReadLine();
        }
    }
    class Graph
    {
        static int V;
        List<int>[] arr;
        public Graph(int v)
        {
            V = v;
            //Console.WriteLine(V+"  "+v);
            arr= new List<int>[V];
            for(int i=0; i<V; i++)
            arr[i] = new List<int>();
            
        }

        public void AddEdge(int i, int j, bool udir)
        {
            arr[i].Add(j);
            if (udir) arr[j].Add(i);
        }

        public void PrintGraph()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("The Edge is {0}  -->  ", i);
                foreach (int j in arr[i])
                    Console.Write(j + " ");
                Console.WriteLine();
            }
           
        }

        public void BFS(int source)
        {
            Queue<int> queue = new Queue<int>();
            bool[] visited = new bool[V];

            queue.Enqueue(source);
            visited[source] = true;
            while(queue.Count > 0)
            {
                int ele = queue.Dequeue();
                Console.WriteLine(ele);
                foreach (int i in arr[ele])
                {
                    if (visited[i] != true)
                    { 
                        queue.Enqueue(i); 
                        visited[i] = true;
                        source = i;
                    }
                    
                }

            }
        }
        public void DfsHelper(int node,bool[] visited)
        {
            Console.WriteLine(node);
            visited[node] = true;
            foreach (int i in arr[node])
            {
                if (visited[i] != true)
                    DfsHelper(i, visited);
            }
        }
        public void DFS(int source)
        {
            bool[]visited = new bool[V];
            DfsHelper(source, visited);
            
        }
    }
}