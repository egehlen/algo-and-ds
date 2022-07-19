namespace AlgorithmsAndDataStructures.DataStructures.BinaryTree
{
    public class Helpers
    {
        public static void Traverse<T>(Node<T> node, Action<Node<T>> expr)
        {
            if (node == null) return;

            expr(node);
            if (node.Left != null) Traverse(node.Left, expr);
            if (node.Right != null) Traverse(node.Right, expr);
        }
    }
}
