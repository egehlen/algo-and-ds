using AlgorithmsAndDataStructures.DataStructures.BinaryTree;

namespace AlgorithmsAndDataStructures.Tests
{
    public class DataStructuresTests
    {
        [Test]
        /*

            Height of a Binary Tree
            =======================

            The height of a binary tree is the number of edges between the tree's root and its furthest leaf.
            For example, the following binary tree is of height: 2

                      ( 4 )
                     /     \
                ( 2 )       ( 6 )
                /   \       /   \
            ( 1 )  ( 3 )  ( 5 )  ( 7 )

            Function Description
            --------------------
                Complete the getHeight or height function in the editor.
                It must return the height of a binary tree as an integer.
                getHeight or height has the following parameter(s):
                    - root: a reference to the root of a binary tree.

                Note: The Height of binary tree with single node is taken as zero.

            Input Format
            ------------
                The first line contains an integer, the number of nodes in the tree.
                Next line contains space separated integer where th integer denotes node[i].data.

                Note: Node values are inserted into a binary search tree before a reference 
                to the tree's root node is passed to your function. In a binary search tree, 
                all nodes on the left branch of a node are less than the node value. 
                All values on the right branch are greater than the node value.

            Output Format
            -------------
                Your function should return a single integer denoting the height of the binary tree.

            Sample Input (from Mocks)
            -------------------------

                        ( 3 )
                        /   \
                    ( 2 )   ( 5 )
                    /       /    \
                ( 1 )     ( 4 )  ( 6 )
                                    \
                                    ( 7 )

            Expected Output: 3
            Explanation: the longest root-to-leaf path has 4 nodes in this path that are 
                         connected by 3 edges, meaning our binary tree's height = 3.

        */
        public void BinaryTree_Height()
        {
            // Arrange
            var tree = Mocks.BinaryTree;
            int longest = -1;
            int expected = 3;

            // Act
            tree.Traverse(tree.Root, x =>
            {
                if (x.Left != null || x.Right != null)
                    longest++;
            });

            // Assert
            Assert.IsTrue(longest > -1);
            Assert.That(expected, Is.EqualTo(longest));
        }
    }
}
