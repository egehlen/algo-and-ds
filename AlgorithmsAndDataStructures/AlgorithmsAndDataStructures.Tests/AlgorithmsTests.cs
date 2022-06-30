using AlgorithmsAndDataStructures.Algorithms;

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
            var index = _01_LinearSearch.Execute(listOfIntegers.ToArray(), query);
            Assert.IsTrue(found ? index > -1 : index == -1);
        }

        [Test]
        [TestCase("", false)]
        [TestCase("SPECIAL_NAME", true)]
        [TestCase("bzzzzzzzzz", false)]
        [TestCase(null, false)]
        public void LinearSearchByIndex_String_Values(string query, bool found)
        {
            var index = _01_LinearSearch.Execute(listOfStrings.ToArray(), query);
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
            var sortedList = listOfIntegers.OrderBy(x => x).ToArray();
            var index = _02_BinarySearch.Execute(sortedList, query);
            Assert.IsTrue(found ? index > -1 : index == -1);
        }

        [Test]
        [TestCase("", false)]
        [TestCase("SPECIAL_NAME", true)]
        [TestCase("bzzzzzzzzz", false)]
        public void BinarySearch_String_Values(string query, bool found)
        {
            var sortedList = listOfStrings.OrderBy(x => x).ToArray();
            var index = _02_BinarySearch.Execute(sortedList, query);
            Assert.IsTrue(found ? index > -1 : index == -1);
        }

        #endregion
    }
}