using sandbox;

class Program
{
    static void Main(string[] args)
    {
        /*
                A
               / \
              B   C
             / \ / \
            D  E F  G
        */
        Graph graph = new Graph();
        graph.AddEdge("A", "B");
        graph.AddEdge("A", "C");
        graph.AddEdge("B", "D");
        graph.AddEdge("B", "E");
        graph.AddEdge("C", "F");
        graph.AddEdge("C", "G");

        GraphTraversal traversal = new();

        // DEBUG CONSOLE
        Console.WriteLine("Breadth-First Search (starting from A):");
        traversal.BreadthFirstSearch(graph, "A");
        Console.Write(Environment.NewLine);

        // DEBUG CONSOLE
        Console.WriteLine("\nDepth-First Search (starting from A):");
        traversal.DepthFirstSearch(graph, "A");
    }
}