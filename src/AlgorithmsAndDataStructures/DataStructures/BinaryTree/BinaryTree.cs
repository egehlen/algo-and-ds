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
    }
}
