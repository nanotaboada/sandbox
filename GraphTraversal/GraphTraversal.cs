namespace sandbox;

/// <summary>
/// Graph Traversal is the process of systematically visiting all the nodes in
/// a graph, exploring their connections and relationships. Imagine navigating
/// a network of interconnected points (nodes) by following the pathways (edges)
/// between them. 
/// </summary>
public class GraphTraversal
{
    /// <summary>
    /// Performs Breadth-First Search (BFS) from a given starting node.
    /// 
    /// Explores all the neighbors of a node before moving deeper, like exploring
    /// all levels of a building before going down to the next floor. This is
    /// efficient for finding the shortest path between two nodes.
    /// </summary>
    /// <param name="graph">A graph using an adjacency list</param>
    /// <param name="startNode">The node from where to start the search</param>
    public void BreadthFirstSearch(Graph graph, string startNode)
    {
        Queue<string> queue = new();
        HashSet<string> visited = new();

        queue.Enqueue(startNode);
        visited.Add(startNode);

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();

            // DEBUG CONSOLE
            if (currentNode != startNode)
            {
                Console.Write(" --> ");
            }

            Console.Write(currentNode);

            foreach (var neighbor in graph.AdjacencyList[currentNode])
            {
                if (!visited.Contains(neighbor))
                {
                    queue.Enqueue(neighbor);
                    visited.Add(neighbor);
                }
            }
        }
    }

    /// <summary>
    /// Performs Depth-First Search (DFS) from a given starting node.
    /// 
    /// Follows one path as deep as possible before backtracking and trying
    /// another, like exploring a maze by going straight until you hit a dead
    /// end, then returning and trying another branch. This is useful for
    /// detecting cycles or topological ordering.
    /// </summary>
    /// <param name="graph">A graph using an adjacency list</param>
    /// <param name="startNode">The node from where to start the search</param>
    public void DepthFirstSearch(Graph graph, string startNode)
    {
        Stack<string> stack = new();
        HashSet<string> visited = new();

        stack.Push(startNode);
        visited.Add(startNode);

        while (stack.Count > 0)
        {
            var currentNode = stack.Pop();

            // DEBUG CONSOLE
            if (currentNode != startNode)
            {
                Console.Write(" --> ");
            }
            
            Console.Write(currentNode);
            

            foreach (string neighbor in graph.AdjacencyList[currentNode])
            {
                if (!visited.Contains(neighbor))
                {
                    stack.Push(neighbor);
                    visited.Add(neighbor);
                }
            }
        }
    }
}