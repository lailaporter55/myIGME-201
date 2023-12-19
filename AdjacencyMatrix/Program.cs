using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyMatrix
{
    internal class Program
    {
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
            int nState = 0; //red
            int nMoves = 0; //count how many moves till reach end

            Thread t = new Thread(DFS);
            t.Start();

            List<Node> shortestPath = GetShortestPathDijkstra();
            


#if USE_MATRIX
                if (mGraph[nState, nUserState])
                {
                    nState = nUserState;
                    ++nMoves;
                }
                else
                {
                    Console.WriteLine("That is an invalid move.");
                }
#else
            int[] thisStateList = lGraph[nState];
            bool valid = false;

            if (thisStateList != null)
            {
                foreach (int n in thisStateList)
                {
                    if (n == nUserState)
                    {
                        valid = true;
                        nState = nUserState;
                        ++nMoves;
                        break;
                    }
                }
            }

            if (!valid)
            {
                Console.WriteLine("That is an invalid move.");
            }
#endif      // A function used by DFS 
            //we are starting at the red dot adn its state is 0
            static void DFSUtil(int v, bool[] visited)
            {
                while (!bWaitingForMove) ;

                // Mark the current node as visited 
                // and print it 
                visited[v] = true;

                Console.Write(v + " ");

                bWaitingForMove = false;

                // Recur for all the vertices 
                // adjacent to this vertex 
                int[] thisStateList = lGraph[v];
                foreach (int n in thisStateList)
                {
                    if (!visited[n])
                    {
                        DFSUtil(n, visited);
                    }
                }
            }
            
            //DFS recursivly checks the point that its at to find the Node that its looking for,
            //DFS goes deeper and deeper into the graph
            // The function to do DFS traversal. 
            // It uses recursive DFSUtil() 
            static void DFS()
            {
                // Mark all the vertices as not visited 
                // (set as false by default in c#) 
                bool[] visited = new bool[lGraph.Length];

                // Call the recursive helper function 
                // to print DFS traversal 
                DFSUtil(0, visited);
            }

            //Dijkstra's algorithm, checks for the shortest path from red to green
            //checks all the edge values and compares them
            //going from red to greem
            static public List<Node> GetShortestPathDijksta()
            {

            }
            static private void DijkstraSearch()
            {
                Node start = nodes[0]; 
                start.minCostToStart = 0;
                List<Node> priorityQ = new List<Node>();
                priorityQ.Add(start);

                do
                {
                    //sort priority queue by costs 
                    priorityQ.Sort();
                    Node node = priorityQ.First();
                    foreach(Edge edge in node.edges)
                    {
                        Node childNode = edge.connectedNode;
                        if (childNode.visited)
                        {
                            continue;
                        }
                        if (childNode.minCostToStart == int.MaxValue ||
                        node.minCostToStart + cnn.cost < childNode.minCostToStart)
                        {
                            childNode.minCostToStart = node.minCostToStart + edge.cost;
                            childNode.nearestToStart = node;
                            if (!priorityQ.Contains(childNode))
                            {
                                priorityQ.Add(childNode);
                            }
                        }
                    }

                    node.visited = true;
                        if (node == game[7]) //when green is found
                        {
                            return;
                        }
                    }
                }
            static private void BuildShortestPath(List<Node> nodes, Node node)
            {
                if(node.nearestToStart == null)
                {
                    return; 
                }
                nodes.Add(node.nearestToStart);
                BuildShortestPath(List, node.nearestToStart); 
            }
            }
        }

        public class Node : IComparable<Node>
        {
            public int nState; 
            public List<Edge> edges = new List<Edge>();

            public int minCostToStart;
            public Node nearestToStart;
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
