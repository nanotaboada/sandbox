namespace sandbox;

/// <summary>
/// Represents a graph using an adjacency list.
/// The adjacency describes the relationship between two nodes (vertices).
/// Two nodes are adjacent if they are connected by an edge (link).
/// </summary>
public class Graph
{
    public Dictionary<string, List<string>> AdjacencyList { get; } = new Dictionary<string, List<string>>();

    /// <summary>
    /// Creates an undirected connection between two nodes.
    /// Edges have no direction, representing two-way relationships.
    /// Traversal can proceed in either direction.
    /// </summary>
    /// <param name="node1">The node to connect from.</param>
    /// <param name="node2">The node to connect to.</param>
    public void AddEdge(string node1, string node2)
    {
        if (!AdjacencyList.ContainsKey(node1)) AdjacencyList.Add(node1, new List<string>());
        if (!AdjacencyList.ContainsKey(node2)) AdjacencyList.Add(node2, new List<string>());

        // node1 --> node2
        AdjacencyList[node1].Add(node2);
        // node2 --> node1
        AdjacencyList[node2].Add(node1);
    }
}