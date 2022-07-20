using AlgorithmsAndDataStructures.DataStructures.BinaryTree;

namespace AlgorithmsAndDataStructures.Tests
{
    public class Mocks
    {
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
