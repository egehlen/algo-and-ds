using AlgorithmsAndDataStructures.DataStructures.BinaryTree;

namespace AlgorithmsAndDataStructures.Tests
{
    public class Mocks
    {
        public static int[] Ints = new int[] { 799, 19, 777, 35, 2, 58, 945, 556, 47, 887 };
        public static string[] Strings = new string[] { "Yasmine", "Ashley", "Jared", "Deron", "Jasen", "Orpha", "Shad", "SPECIAL_NAME", "General", "Alex" };

        /*
        
        Simple binary tree:

                    ( 3 )
                    /   \
                ( 2 )   ( 5 )
                /       /    \
            ( 1 )     ( 4 )  ( 6 )
                                \
                                ( 7 )

        */
        public static BinaryTree<int> BinaryTree = new BinaryTree<int>()
        {
            Root = new Node<int>(3)
            {
                Left = new Node<int>(2)
                {
                    Left = new Node<int>(1)
                },
                Right = new Node<int>(5)
                {
                    Left = new Node<int>(4),
                    Right = new Node<int>(6)
                    {
                        Right = new Node<int>(7)
                    }
                }
            }
        };
    }
}
