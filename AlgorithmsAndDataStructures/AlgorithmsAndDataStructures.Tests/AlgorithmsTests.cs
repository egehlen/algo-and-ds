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
            listOfIntegers = Enumerable.Range(0, 20).Select(_ => Faker.RandomNumber.Next(0, 1000)).ToArray();
            listOfIntegers[new Random().Next(0, 19)] = 777; // Special number

            listOfStrings = Enumerable.Range(0, 20).Select(_ => Faker.Name.First()).ToArray();
            listOfStrings[new Random().Next(0, 19)] = "SPECIAL_WORD"; // Special word
        }

        [Test]
        [TestCase(0, false)]
        [TestCase(777, true)]
        [TestCase(1001, false)]
        public void LinearSearchByIndex_Int_Values(int query, bool found)
        {
            var index = _01_LinearSearch.Execute(listOfIntegers.ToArray(), query);
            Assert.IsTrue(found ? index > -1 : index == -1);
        }

        [Test]
        [TestCase("", false)]
        [TestCase("SPECIAL_WORD", true)]
        [TestCase("bzzzzzzzzz", false)]
        public void LinearSearchByIndex_String_Values(string query, bool found)
        {
            var index = _01_LinearSearch.Execute(listOfStrings.ToArray(), query);
            Assert.IsTrue(found ? index > -1 : index == -1);
        }
    }
}