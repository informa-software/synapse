﻿namespace Neuroglia.Blazor.Dagre.Models
{
    /// <summary>
    /// Provides data structures for undirected and directed multi-graphs
    /// </summary>
    public interface IGraphLib
    {

        /// <summary>
        /// Gets list of direct children of node v.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// children nodes names list.
        /// </returns>
        Task<string[]> Children(string v);

        /// <summary>
        /// Gets the label for the specified edge.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// value associated with specified edge.
        /// </returns>
        Task<object> Edge(string v, string w, string name);

        /// <summary>
        /// Gets the label for the specified edge.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// value associated with specified edge.
        /// </returns>
        Task<object> Edge(IGraphLibEdge e);

        /// <summary>
        /// Gets the number of edges in the graph.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// edges count.
        /// </returns>
        Task<double> EdgeCount();

        /// <summary>
        /// Gets edges of the graph. In case of compound graph subgraphs are not considered.
        /// Complexity: O(|E|).
        /// </summary>
        /// <returns>
        /// graph edges list.
        /// </returns>
        Task<IGraphLibEdge[]> Edges();

        /// <summary>
        /// Creates new graph with nodes filtered via filter. Edges incident to rejected node
        /// are also removed. In case of compound graph, if parent is rejected by filter,
        /// than all its children are rejected too.
        /// Average-case complexity: O(|E|+|V|).
        /// </summary>
        /// <returns>
        /// new graph made from current and nodes filtered.
        /// </returns>
        Task<IGraphLib> FilterNodes(Func<string, bool> filter);

        /// <summary>
        /// Gets the graph label.
        /// </summary>
        /// <returns>
        /// currently assigned label for the graph or undefined if no label assigned.
        /// </returns>
        Task<string?> Graph();

        /// <summary>
        /// Detects whether the graph contains specified edge or not. No subgraphs are considered.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// whether the graph contains the specified edge or not.
        /// </returns>
        Task<bool> HasEdge(string v, string w, string name);

        /// <summary>
        /// Detects whether the graph contains specified edge or not. No subgraphs are considered.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// whether the graph contains the specified edge or not.
        /// </returns>
        Task<bool> HasEdge(IGraphLibEdge edge);

        /// <summary>
        /// Detects whether graph has a node with specified name or not.
        /// </summary>
        /// <returns>
        /// true if graph has node with specified name, false - otherwise.
        /// </returns>
        Task<bool> HasNode(string name);

        /// <summary>
        /// Return all edges that point to the node v. Optionally filters those edges down to just those
        /// coming from node u. Behavior is undefined for undirected graphs - use nodeEdges instead.
        /// Complexity: O(|E|).
        /// </summary>
        /// <returns>
        /// edges descriptors list if v is in the graph, or undefined otherwise.
        /// </returns>
        Task<IGraphLibEdge[]?> InEdges(string v, string w);

        /// <summary>
        /// Whether graph was created with 'compound' flag set to true or not.
        /// </summary>
        /// <returns>
        /// whether a node of the graph can have subnodes.
        /// </returns>
        Task<bool> IsCompound();

        /// <summary>
        /// Whether graph was created with 'directed' flag set to true or not.
        /// </summary>
        /// <returns>
        /// whether the graph edges have an orientation.
        /// </returns>
        Task<bool> IsDirected();

        /// <summary>
        /// Whether graph was created with 'multigraph' flag set to true or not.
        /// </summary>
        /// <returns>
        /// whether the pair of nodes of the graph can have multiple edges.
        /// </returns>
        Task<bool> IsMultigraph();

        /// <summary>
        /// Return all nodes that are predecessors or successors of the specified node or undefined if
        /// node v is not in the graph.
        /// Complexity: O(|V|).
        /// </summary>
        /// <returns>
        /// node identifiers list or undefined if v is not in the graph.
        /// </returns>
        Task<string[]?> Neighbors(string v);

        /// <summary>
        /// Gets the label of node with specified name.
        /// Complexity: O(|V|).
        /// </summary>
        /// <returns>
        /// label value of the node.
        /// </returns>
        Task<object> Node(string name);

        /// <summary>
        /// Gets the number of nodes in the graph.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// nodes count.
        /// </returns>
        Task<double> NodeCount();

        /// <summary>
        /// Returns all edges to or from node v regardless of direction. Optionally filters those edges
        /// down to just those between nodes v and w regardless of direction.
        /// Complexity: O(|E|).
        /// </summary>
        /// <returns>
        /// edges descriptors list if v is in the graph, or undefined otherwise.
        /// </returns>
        Task<IGraphLibEdge[]?> NodeEdges(string v, string w);

        /// <summary>
        /// Gets all nodes of the graph. Note, the in case of compound graph subnodes are
        /// not included in list.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// list of graph nodes.
        /// </returns>
        Task<string[]> Nodes();

        /// <summary>
        /// Return all edges that are pointed at by node v. Optionally filters those edges down to just
        /// those point to w. Behavior is undefined for undirected graphs - use nodeEdges instead.
        /// Complexity: O(|E|).
        /// </summary>
        /// <returns>
        /// edges descriptors list if v is in the graph, or undefined otherwise.
        /// </returns>
        Task<IGraphLibEdge[]?> OutEdges(string v, string w);

        /// <summary>
        /// Gets parent node for node v.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// parent node name or void if v has no parent.
        /// </returns>
        Task<string[]?> Parent(string v);

        /// <summary>
        /// Return all nodes that are predecessors of the specified node or undefined if node v is not in
        /// the graph. Behavior is undefined for undirected graphs - use neighbors instead.
        /// Complexity: O(|V|).
        /// </summary>
        /// <returns>
        /// node identifiers list or undefined if v is not in the graph.
        /// </returns>
        Task<string[]?> Predecessors(string v);

        /// <summary>
        /// Removes the specified edge from the graph. No subgraphs are considered.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// the graph, allowing this to be chained with other functions.
        /// </returns>
        Task<IGraphLib> RemoveEdge(IGraphLibEdge edge);

        /// <summary>
        /// Removes the specified edge from the graph. No subgraphs are considered.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// the graph, allowing this to be chained with other functions.
        /// </returns>
        Task<IGraphLib> RemoveEdge(string v, string w, string name);

        /// <summary>
        /// Remove the node with the name from the graph or do nothing if the node is not in
        /// the graph. If the node was removed this function also removes any incident
        /// edges.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// the graph, allowing this to be chained with other functions.
        /// </returns>
        Task<IGraphLib> RemoveNode(string name);

        /// <summary>
        /// Sets the default edge label. This label will be assigned as default label
        /// in case if no label was specified while setting an edge.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// the graph, allowing this to be chained with other functions.
        /// </returns>
        Task<IGraphLib> SetDefaultEdgeLabel(object label);

        /// <summary>
        /// Sets the default edge label factory function. This function will be invoked
        /// each time when setting an edge with no label specified and returned value
        /// will be used as a label for edge.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// the graph, allowing this to be chained with other functions.
        /// </returns>
        Task<IGraphLib> SetDefaultEdgeLabel(Func<string, object> labelFn);

        /// <summary>
        /// Sets the default node label. This label will be assigned as default label
        /// in case if no label was specified while setting a node.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// the graph, allowing this to be chained with other functions.
        /// </returns>
        Task<IGraphLib> SetDefaultNodeLabel(object label);

        /// <summary>
        /// Sets the default node label factory function. This function will be invoked
        /// each time when setting a node with no label specified and returned value
        /// will be used as a label for node.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// the graph, allowing this to be chained with other functions.
        /// </returns>
        Task<IGraphLib> SetDefaultNodeLabel(Func<string, object> labelFn);

        /// <summary>
        /// Creates or updates the label for the edge (v, w) with the optionally supplied
        /// name. If label is supplied it is set as the value for the edge. If label is not
        /// supplied and the edge was created by this call then the default edge label will
        /// be assigned. The name parameter is only useful with multigraphs.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// the graph, allowing this to be chained with other functions.
        /// </returns>
        Task<IGraphLib> SetEdge(string v, string w, object label, string name);

        /// <summary>
        /// Creates or updates the label for the specified edge. If label is supplied it is
        /// set as the value for the edge. If label is not supplied and the edge was created
        /// by this call then the default edge label will be assigned. The name parameter is
        /// only useful with multigraphs.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// the graph, allowing this to be chained with other functions.
        /// </returns>
        Task<IGraphLib> SetEdge(IGraphLibEdge edge, object label);

        /// <summary>
        /// Sets the label of the graph.
        /// </summary>
        /// <returns>
        /// the graph, allowing this to be chained with other functions.
        /// </returns>
        Task<IGraphLib> SetGraph(string label);

        /// <summary>
        /// Creates or updates the value for the node v in the graph. If label is supplied
        /// it is set as the value for the node. If label is not supplied and the node was
        /// created by this call then the default node label will be assigned.
        /// Complexity: O(1).
        /// </summary>
        /// <returns>
        /// the graph, allowing this to be chained with other functions.
        /// </returns>
        Task<IGraphLib> SetNode(string name, object label);

        /// <summary>
        /// Invokes setNode method for each node in names list.
        /// Complexity: O(|names|).
        /// </summary>
        /// <returns>
        /// the graph, allowing this to be chained with other functions.
        /// </returns>
        Task<IGraphLib> SetNodes(string[] names, object label);

        /// <summary>
        /// Sets node p as a parent for node v if it is defined, or removes the
        /// parent for v if p is undefined. Method throws an exception in case of
        /// invoking it in context of noncompound graph.
        /// Average-case complexity: O(1).
        /// </summary>
        /// <returns>
        /// the graph, allowing this to be chained with other functions.
        /// </returns>
        Task<IGraphLib> SetParent(string v, string p);

        /// <summary>
        /// Establish an edges path over the nodes in nodes list. If some edge is already
        /// exists, it will update its label, otherwise it will create an edge between pair
        /// of nodes with label provided or default label if no label provided.
        /// Complexity: O(|nodes|).
        /// </summary>
        /// <returns>
        /// the graph, allowing this to be chained with other functions.
        /// </returns>
        Task<IGraphLib> SetPath(string[] nodes, object label);

        /// <summary>
        /// Gets list of nodes without out-edges.
        /// Complexity: O(|V|).
        /// </summary>
        /// <returns>
        /// the graph source nodes.
        /// </returns>
        Task<string[]> Sinks();

        /// <summary>
        /// Gets list of nodes without in-edges.
        /// Complexity: O(|V|).
        /// </summary>
        /// <returns>
        /// the graph source nodes.
        /// </returns>
        Task<string[]> Sources();

        /// <summary>
        /// Return all nodes that are successors of the specified node or undefined if node v is not in
        /// the graph. Behavior is undefined for undirected graphs - use neighbors instead.
        /// Complexity: O(|V|).
        /// </summary>
        /// <returns>
        /// node identifiers list or undefined if v is not in the graph.
        /// </returns>
        Task<string[]?> Successors(string v);
    }
}
