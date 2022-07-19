using AlgorithmsAndDataStructures.DataStructures.BinaryTree;

namespace AlgorithmsAndDataStructures.Tests
{
    public class DataStructuresTests
    {
        [Test]
        public void BinaryTree_tests()
        {
            var tree = new BinaryTree<int>(3)
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

            int longest = -1;

            Helpers.Traverse(tree.Root, x =>
            {
                if (x.Left != null || x.Right != null)
                    longest++;
            });

            Assert.IsTrue(longest > -1);
        }
    }
}
