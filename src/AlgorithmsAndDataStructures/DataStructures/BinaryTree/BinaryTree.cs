namespace AlgorithmsAndDataStructures.DataStructures.BinaryTree
{
    public class BinaryTree<T>
    {
        public Node<T>? Root { get; set; } = null;

        public BinaryTree()
        { }

        public BinaryTree(T root)
        {
            this.Root = new Node<T>(root);
        }

        public void Traverse<T>(Node<T> node, Action<Node<T>> expr)
        {
            if (node == null) return;

            expr(node);
            if (node.Left != null) Traverse(node.Left, expr);
            if (node.Right != null) Traverse(node.Right, expr);
        }
    }
}
