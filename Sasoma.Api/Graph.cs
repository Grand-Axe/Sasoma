using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using Sasoma.API;
using Sasoma.Microdata;

namespace Sasoma.Api
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public class Graph : CacheManager
    {
        private List<GraphNode> nodes;
        private List<GraphNode> GraphNodeCollection
        {
            get
            {
                nodes = (List<GraphNode>)this.GetFromCache("GraphNodeCollection");
                if (nodes == null | nodes.Count == 0)
                {
                    this.SetCache("GraphNodeCollection", new GraphNode());
                }
                return nodes;
            }
        }

        private List<Edge> edges;
        private List<Edge> EdgeCollection
        {
            get
            {
                edges = (List<Edge>)this.GetFromCache("EdgeCollection");
                if (edges == null | edges.Count == 0)
                {
                    this.SetCache("EdgeCollection", new Edge());
                }
                return edges;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public object FindGraphNode(string name)
        {
            int id = Search.GetInstance(name);
            object returnVal = FindGraphNode(id, new GraphNode());
            return returnVal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="graphNodeId"></param>
        /// <param name="graphNode"></param>
        /// <returns></returns>
        public GraphNode FindGraphNode(int graphNodeId, GraphNode graphNode)
        {
            GraphNode foundNode = new GraphNode();
            int end = 0;
            //int start = 0;
            for (int i = 0; i < GraphNodeCollection.Count; i++)
            {
                if (GraphNodeCollection[i].GraphNodeId == graphNodeId)
                {
                    return GraphNodeCollection[i];
                }
                else
                {
                    if (GraphNodeCollection[i].Edges.Count > 0)
                    {
                        for (int j = 0; j < GraphNodeCollection[i].Edges.Count; j++)
                        {
                            end = GraphNodeCollection[i].Edges[j].EndGraphNodeId;
                            if (end == graphNodeId)
                            {
                                return GetGraphNodeById(GraphNodeCollection[i].Edges[j].EndGraphNodeId);
                            }
                            else
                            {
                                FindGraphNode(graphNodeId, GetGraphNodeById(GraphNodeCollection[i].Edges[j].EndGraphNodeId));
                            }
                        }
                    }
                }
            }
            return foundNode;
        }

        public GraphNode GetGraphNodeParent(int graphNodeId)
        {
            GraphNode foundNode = new GraphNode();
            int end = 0;
            //int start = 0;
            for (int i = 0; i < GraphNodeCollection.Count; i++)
            {
                if (GraphNodeCollection[i].ParentId == graphNodeId)
                {
                    return GraphNodeCollection[i];
                }
                else
                {
                    if (GraphNodeCollection[i].Edges.Count > 0)
                    {
                        for (int j = 0; j < GraphNodeCollection[i].Edges.Count; j++)
                        {
                            end = GraphNodeCollection[i].Edges[j].StartGraphNodeId;
                            if (end == graphNodeId)
                            {
                                return GetGraphNodeById(GraphNodeCollection[i].Edges[j].StartGraphNodeId);
                            }
                            else
                            {
                                FindGraphNode(graphNodeId, GetGraphNodeById(GraphNodeCollection[i].Edges[j].StartGraphNodeId));
                            }
                        }
                    }
                }
            }
            return foundNode;
        }

        public object FindEdge(int edgeId)
        {
            object foundEdge = new object();
            for (int i = 0; i < EdgeCollection.Count; i++)
            {
                if (EdgeCollection[i].EdgeId == edgeId)
                {
                    return EdgeCollection[i];
                }
            }
            return foundEdge;
        }

        public GraphNode GetGraphNodeById(int id)
        {
            GraphNode node = new GraphNode();
            for (int i = 0; i < GraphNodeCollection.Count; i++)
            {
                if (id == GraphNodeCollection[i].GraphNodeId)
                    return GraphNodeCollection[i];
            }
            return node;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="edge"></param>
        /// <param name="graphNode"></param>
        public void AddGraphNode(Edge edge, int parentGraphNodeId, GraphNode graphNode)
        {
            GraphNode parent = GetGraphNodeById(parentGraphNodeId);
            edge.StartGraphNodeId = parentGraphNodeId;
            edge.EndGraphNodeId = graphNode.GraphNodeId;
            EdgeCollection.Add(edge);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="graphNodeId"></param>
        public bool RemoveGraphNode(int graphnodeId)
        {
            GraphNode node = GetGraphNodeById(graphnodeId);
            node.Edges.RemoveRange(0, node.Edges.Count);
            return GraphNodeCollection.Remove(node);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="edge"></param>
        /// <param name="graphNode"></param>
        /// <param name="graphNodeFoUpdate"></param>
        public void UpdateGraphNode(Edge edge, Edge edgeForUpadate, GraphNode graphNode, GraphNode graphNodeForUpdate)
        {
            graphNodeForUpdate = graphNode;
            edgeForUpadate = edge;
        }
    }
}
