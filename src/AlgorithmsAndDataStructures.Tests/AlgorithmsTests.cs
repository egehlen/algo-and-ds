using AlgorithmsAndDataStructures.Algorithms.Search;
using AlgorithmsAndDataStructures.Algorithms.Sorting;

namespace AlgorithmsAndDataStructures.Tests
{
    public class AlgorithmsTests
    {
        #region [ Linear search ]

        [Test]
        [TestCase(0, false)]
        [TestCase(777, true)]
        [TestCase(1001, false)]
        [TestCase(-123, false)]
        public void LinearSearchByIndex_Int_Values(int query, bool found)
        {
            // Arrange -> test cases
            // Act
            var index = _01_LinearSearch.Execute(Mocks.Ints, query);

            // Assert
            Assert.IsTrue(found ? index > -1 : index == -1);
        }

        [Test]
        [TestCase("", false)]
        [TestCase("SPECIAL_NAME", true)]
        [TestCase("bzzzzzzzzz", false)]
        [TestCase(null, false)]
        public void LinearSearchByIndex_String_Values(string query, bool found)
        {
            // Arrange -> test cases
            // Act
            var index = _01_LinearSearch.Execute(Mocks.Strings, query);

            // Assert
            Assert.IsTrue(found ? index > -1 : index == -1);
        }

        #endregion

        #region [ Binary search ]

        [Test]
        [TestCase(0, false)]
        [TestCase(777, true)]
        [TestCase(1001, false)]
        [TestCase(-123, false)]
        public void BinarySearch_Int_Values(int query, bool found)
        {
            // Arrange
            var sortedList = Mocks.Ints.OrderBy(x => x).ToArray();

            // Act
            var index = _02_BinarySearch.Execute(sortedList, query);

            // Assert
            Assert.IsTrue(found ? index > -1 : index == -1);
        }

        [Test]
        [TestCase("", false)]
        [TestCase("SPECIAL_NAME", true)]
        [TestCase("bzzzzzzzzz", false)]
        public void BinarySearch_String_Values(string query, bool found)
        {
            // Arrange
            var sortedList = Mocks.Strings.OrderBy(x => x).ToArray();

            // Act
            var index = _02_BinarySearch.Execute(sortedList, query);

            // Assert
            Assert.IsTrue(found ? index > -1 : index == -1);
        }

        #endregion

        #region [ Bubble Sort ]

        [Test]
        public void BubbleSort_Int_Values()
        {
            // Arrange
            var localSort = Mocks.Ints.OrderBy(x => x).ToArray();

            // Act
            var algoSort = _01_BubbleSort.Execute(Mocks.Ints);

            // Assert
            Assert.IsNotNull(algoSort);
            Assert.That(algoSort.Length, Is.EqualTo(localSort.Length));
            Assert.That(algoSort, Is.EqualTo(localSort));
        }

        [Test]
        public void BubbleSort_String_Values()
        {
            // Arrange
            var localSort = Mocks.Strings.OrderBy(x => x).ToArray();

            // Act
            var algoSort = _01_BubbleSort.Execute(Mocks.Strings);

            // Assert
            Assert.IsNotNull(algoSort);
            Assert.That(algoSort.Length, Is.EqualTo(localSort.Length));
            Assert.That(algoSort, Is.EqualTo(localSort));
        }

        #endregion

        #region [ Selection Sort ]

        [Test]
        public void SelectionSort_Int_Values()
        {
            // Arrange
            var localSort = Mocks.Ints.OrderBy(x => x).ToArray();

            // Act
            var algoSort = _02_SelectionSort.Execute(Mocks.Ints);

            // Assert
            Assert.IsNotNull(algoSort);
            Assert.That(algoSort.Length, Is.EqualTo(localSort.Length));
            Assert.That(algoSort, Is.EqualTo(localSort));
        }

        [Test]
        public void SelectionSort_String_Values()
        {
            // Arrange
            var localSort = Mocks.Strings.OrderBy(x => x).ToArray();

            // Act
            var algoSort = _02_SelectionSort.Execute(Mocks.Strings);

            // Assert
            Assert.IsNotNull(algoSort);
            Assert.That(algoSort.Length, Is.EqualTo(localSort.Length));
            Assert.That(algoSort, Is.EqualTo(localSort));
        }

        #endregion

        #region [ Insertion Sort ]

        [Test]
        public void InsertionSort_Int_Values()
        {
            // Arrange
            var localSort = Mocks.Ints.OrderBy(x => x).ToArray();

            // Act
            var algoSort = _03_InsertionSort.Execute(Mocks.Ints);

            // Assert
            Assert.IsNotNull(algoSort);
            Assert.That(algoSort.Length, Is.EqualTo(localSort.Length));
            Assert.That(algoSort, Is.EqualTo(localSort));
        }

        #endregion

        #region [ Merge Sort ]

        [Test]
        public void MergeSort_Int_Values()
        {
            // Arrange
            var localSort = Mocks.Ints.OrderBy(x => x).ToArray();

            // Act
            var algoSort = _04_MergeSort.Execute(Mocks.Ints);

            // Assert
            Assert.IsNotNull(algoSort);
            Assert.That(algoSort.Length, Is.EqualTo(localSort.Length));
            Assert.That(algoSort, Is.EqualTo(localSort));
        }

        #endregion

    }
}