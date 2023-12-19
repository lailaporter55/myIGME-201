using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyMatrix
{
    internal class Program
    {
#if USE_MATRIX
        static bool[,] mGraph = new bool[,]
        {
           { false   , true    , false   , false   , true    , false   , false   , false },
           { false   , false   , false   , true    , false   , false   , false   , false },
           { true    , false   , false   , false   , false   , false   , false   , false },
           { false   , false   , false   , false   , false   , false   , false   , true },
           { false   , false   , false   , false   , false   , false   , true    , false },
           { false   , false   , false   , false   , false   , false   , false   , false },
           { false   , false   , false   , false   , false   , false   , false   , true },
           { false   , false   , false   , false   , false   , true    , false   , false }
        };
        static int[][] lGraph = new int[][]
        {
            new int[]{1,5},
            new int[]{8},
            new int[]{6},
            null
        };
#else
        static bool[,] mGraph = new bool[,]
        {
            { false   , true    , true    , false   , true    , false   , false   , false },
           { true    , false   , false   , true    , false   , false   , false   , false },
           { true    , false   , false   , false   , false   , false   , false   , false },
           { false   , true    , false   , false   , false   , false   , false   , true  },
           { true    , false   , false   , false   , false   , false   , true    , false },
           { false   , false   , false   , false   , false   , false   , false   , true  },
           { false   , false   , false   , false   , true    , false   , false   , true  },
           { false   , false   , false   , true    , false   , true    , true    , false }
        };
        static int[][] lGraph = new int[][]
        {
            new int[]{1,5},
            new int[]{0},
            new int[]{1},
            new int[]{1},
            new int[]{1},
            new int[]{6}
        };
#endif
        static List<Node> nodes = new List<Node>();

        static void Main(string[] args)
        {
            //add nodes to graph
            Node node;
            node = new Node(0); //red
            nodes.Add(node);
            node = new Node(1); //blue
            nodes.Add(node);
            node = new Node(2); //gray
            nodes.Add(node);
            node = new Node(3); //lightblue
            nodes.Add(node);
            node = new Node(4); //yellow
            nodes.Add(node);
            node = new Node(5); //orange
            nodes.Add(node);
            node = new Node(6); //purple
            nodes.Add(node);
            node = new Node(7); //green
            nodes.Add(node);

            //add edges and values
            //connect red dot to blue and gray
            nodes[0].AddEdge(1, nodes[1]);
            nodes[0].AddEdge(5, nodes[2]);
            //connect blue to light blue and yellow
            nodes[1].AddEdge(8, nodes[4]);
            nodes[1].AddEdge(1, nodes[3]);
            //connect gray to lightblue and orange
            nodes[2].AddEdge(0, nodes[3]);
            nodes[2].AddEdge(1, nodes[5]);
            //connect lightblue to blue and gray
            nodes[3].AddEdge(0, nodes[2]);
            nodes[3].AddEdge(1, nodes[1]);
            //connect orange to purple
            nodes[5].AddEdge(1, nodes[6]);
            //connect purple to yellow
            nodes[6].AddEdge(1, nodes[4]);
            //connect yellow to green
            nodes[4].AddEdge(6, nodes[7]);

        }

        public class Node : IComparable<Node>
        {
            public int nState; 
            public List<Edge> edges = new List<Edge>();

            public int minCostToStart;
            public Node nearestTpStart;
            public bool visited; 

            public Node(int nState)
            {
                this.nState = nState;
                this.minCostToStart = int.MaxValue;
            }
            public void AddEdge(int cost, Node connection)
            {
                Edge e = new Edge(cost, connection); 
                edges.Add(e);
            }
            public int CompareTo(Node n)
            {
                //compare the distance btw two nodes
                return this.minCostToStart.CompareTo(n.minCostToStart); 
            }
        } 
        public class Edge : IComparable<Edge>
        {
            public int cost;
            public Node connectedNode; 

            public Edge(int cost, Node connectedNode)
            {
                this.cost = cost;
                this.connectedNode = connectedNode;

                public Edge(int code, Node connectedNode)
                {
                    this.cost = code;
                    this.connectedNode = connectedNode;
                }
                public int CompareTo(Edge e)
                {
                    return this.cost.CompareTo(e.cost);
                }
            }
        }

    }
}
