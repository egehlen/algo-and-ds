namespace AlgorithmsAndDataStructures.Algorithms.Search
{
    /*
        Binary search
        =============

        Binary search works by spliting the collection in half and check for a condition
        that tells wether the value is in the first or in the second portion of the
        collection, or even if it's exactly in the middle. While the desired value is not
        found, it keeps looping through the collection and dividing it until the value is
        found or it hits the end of the collection without finding a value. This approach
        is also known as "divide and conquer". It works in ORDERED collections only.

        Time complexity (worst): O(log n)
        Space complexity: O(1)
    */

    public class _02_BinarySearch
    {
        public static int Execute<T>(T[] values, T query)
        {
            if (query == null || values.Length == 0)
                return -1;

            int start = 0;
            int end = values.Length - 1;
            int middle = Math.Abs((start + end) / 2);

            while (!values[middle].Equals(query) && start <= end)
            {
                if (Utility.Compare(query, values[middle]))
                    end = middle - 1;
                else
                    start = middle + 1;

                middle = Math.Abs((start + end) / 2);
            }

            if (values[middle] == null)
                return -1;
            else
                return values[middle].Equals(query) ? middle : -1;
        }
    }
}
