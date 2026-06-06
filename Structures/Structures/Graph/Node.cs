namespace Structures.Graph;

/// <summary>
/// Record for breadth search
/// </summary>
public record Node(string Name, Node[]? Neighbors);