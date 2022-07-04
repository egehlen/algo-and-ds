namespace AlgorithmsAndDataStructures.Algorithms.Search
{
    /*
        Binary search
        -------------

        Binary search works by spliting the collection in half and check
        for a condition that tells wether the value is in the first or in
        the second portion of the collection, or even if it's exactly in
        the middle. While the desired value is not found, it keeps looping
        through the collection and dividing it until the value is found
        or it hits the end of the collection without finding a value. This
        approach is also known as "divide and conquer".
     
        Best suitable for:
            - ORDERED collections only;

        Time complexity:
            - Best: O(1) => when the value matches occurs in the first iteration
            - Worst/avg: O(log n) => varies according the length of the input

        Space complexity:
            - Best/worst/avg: O(1) => constant 3 variables no matter the size of the input
     
     */


    public class _02_BinarySearch
    {
        public static int Execute(int[] values, int query)
        {
            int start = 0;
            int end = values.Length - 1;
            int middle = Math.Abs((start + end) / 2);

            while (!values[middle].Equals(query) && start <= end)
            {
                if (query < values[middle])
                    end = middle - 1;
                else
                    start = middle + 1;

                middle = Math.Abs((start + end) / 2);
            }

            return values[middle] == query ? middle : -1;
        }

        public static int Execute(string[] values, string query)
        {
            int start = 0;
            int end = values.Length - 1;
            int middle = Math.Abs((start + end) / 2);

            while (!values[middle].Equals(query) && start <= end)
            {
                if (query.CompareTo(values[middle]) < 0)
                    end = middle - 1;
                else
                    start = middle + 1;

                middle = Math.Abs((start + end) / 2);
            }

            return values[middle] == query ? middle : -1;
        }
    }
}
