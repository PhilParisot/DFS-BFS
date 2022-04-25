using System.Runtime.CompilerServices;

var root = new Node(1);

root.LNode = new Node(2) { LNode = new Node(4), RNode = new Node(5) };

root.RNode = new Node(3);

List<int> PreorderResult = new();

PreorderTraversal(root, PreorderResult);

List<int> InorderResult = new();

InorderTraversal(root, InorderResult);

List<int> PostorderResult = new();

PostorderTraversal(root, PostorderResult);

List<int> BreadthFirstResult = new();

BreadthFirstTraversal(root, BreadthFirstResult);


System.Console.WriteLine();





static void PreorderTraversal(Node parent, List<int> traversal)
{
    traversal.Add(parent.Name);

    if (parent.LNode != null)
    {
        PreorderTraversal(parent.LNode, traversal);
    }

    if (parent.RNode != null)
    {
        PreorderTraversal(parent.RNode, traversal);
    }
}

static void InorderTraversal(Node parent, List<int> traversal)
{
    if (parent.LNode != null)
    {
        InorderTraversal(parent.LNode, traversal);
    }

    traversal.Add(parent.Name);

    if (parent.RNode != null)
    {
        InorderTraversal(parent.RNode, traversal);
    }

}

static void PostorderTraversal(Node parent, List<int> traversal)
{
    if (parent.LNode != null)
    {
        PostorderTraversal(parent.LNode, traversal);
    }

    if (parent.RNode != null)
    {
        PostorderTraversal(parent.RNode, traversal);
    }

    traversal.Add(parent.Name);
}

static void BreadthFirstTraversal(Node parent, List<int> traversal)
{
    if (traversal.Count < 1)
    {
        traversal.Add(parent.Name);
        if (parent.LNode != null)
            traversal.Add(parent.LNode.Name);
        if (parent.RNode != null)
            traversal.Add(parent.RNode.Name);
    }
    else
    {
        if (parent.LNode != null)
            traversal.Add(parent.LNode.Name);
        if (parent.RNode != null)
            traversal.Add(parent.RNode.Name);
    }
    if (parent.LNode != null)
        BreadthFirstTraversal(parent.LNode, traversal);
    if (parent.RNode != null)
        BreadthFirstTraversal(parent.RNode, traversal);
}

class Node
{
    public int Name { get; }
    public Node? LNode { get; set; }
    public Node? RNode { get; set; }

    public Node(int name)
    {
        this.Name = name;
    }
}