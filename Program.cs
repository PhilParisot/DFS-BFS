var root = new Node(1);

root.LNode = new Node(2) { LNode = new Node(4), RNode = new Node(5) };

root.RNode = new Node(3);

List<int> PreorderResult = new();

PreorderTraversal(root, PreorderResult);

List<int> InorderResult = new();

InorderTraversal(root, InorderResult);

List<int> PostorderResult = new();

PostorderTraversal(root, PostorderResult);

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