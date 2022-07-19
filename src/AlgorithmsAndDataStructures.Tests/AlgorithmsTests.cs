using AlgorithmsAndDataStructures.Algorithms.Search;
using AlgorithmsAndDataStructures.Algorithms.Sorting;

namespace AlgorithmsAndDataStructures.Tests
{
    public class AlgorithmsTests
    {
        private int[] listOfIntegers = { };
        private string[] listOfStrings = { };

        [OneTimeSetUp]
        public void Init()
        {
            listOfIntegers = new int[] { 799, 19, 777, 35, 2, 58, 945, 556, 47, 887 };
            listOfStrings = new string[] { "Yasmine", "Ashley", "Jared", "Deron", "Jasen", "Orpha", "Shad", "SPECIAL_NAME", "General", "Alex"  };
        }

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
            var index = _01_LinearSearch.Execute(listOfIntegers.ToArray(), query);
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
            var index = _01_LinearSearch.Execute(listOfStrings.ToArray(), query);
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
            var sortedList = listOfIntegers.OrderBy(x => x).ToArray();
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
            var sortedList = listOfStrings.OrderBy(x => x).ToArray();
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
            var localSort = listOfIntegers.OrderBy(x => x).ToArray();
            // Act
            var algoSort = _01_BubbleSort.Execute(listOfIntegers);
            // Assert
            Assert.IsNotNull(algoSort);
            Assert.AreEqual(localSort.Length, algoSort.Length);
            Assert.AreEqual(localSort, algoSort);
        }

        [Test]
        public void BubbleSort_String_Values()
        {
            // Arrange
            var localSort = listOfStrings.OrderBy(x => x).ToArray();
            // Act
            var algoSort = _01_BubbleSort.Execute(listOfStrings);
            // Assert
            Assert.IsNotNull(algoSort);
            Assert.AreEqual(localSort.Length, algoSort.Length);
            Assert.AreEqual(localSort, algoSort);
        }

        #endregion

        #region [ Selection Sort ]

        [Test]
        public void SelectionSort_Int_Values()
        {
            // Arrange
            var localSort = listOfIntegers.OrderBy(x => x).ToArray();
            // Act
            var algoSort = _02_SelectionSort.Execute(listOfIntegers);
            // Assert
            Assert.IsNotNull(algoSort);
            Assert.AreEqual(localSort.Length, algoSort.Length);
            Assert.AreEqual(localSort, algoSort);
        }

        [Test]
        public void SelectionSort_String_Values()
        {
            // Arrange
            var localSort = listOfStrings.OrderBy(x => x).ToArray();
            // Act
            var algoSort = _02_SelectionSort.Execute(listOfStrings);
            // Assert
            Assert.IsNotNull(algoSort);
            Assert.AreEqual(localSort.Length, algoSort.Length);
            Assert.AreEqual(localSort, algoSort);
        }

        #endregion

        #region [ Insertion Sort ]

        [Test]
        public void InsertionSort_Int_Values()
        {
            // Arrange
            var localSort = listOfIntegers.OrderBy(x => x).ToArray();
            // Act
            var algoSort = _03_InsertionSort.Execute(listOfIntegers);
            // Assert
            Assert.IsNotNull(algoSort);
            Assert.AreEqual(localSort.Length, algoSort.Length);
            Assert.AreEqual(localSort, algoSort);
        }

        #endregion


    }
}