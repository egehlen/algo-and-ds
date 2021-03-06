namespace AlgorithmsAndDataStructures.Algorithms.Search
{
    /*
        Linear search
        =============

        Linear search works by checking each element of the collection in order to find
        the matching element. It matches the value by direct comparison. It is best
        suitable to unordered collections, and generics can be used as seen in the
        implementation below.

        Time complexity (worst): O(n)
        Space complexity: O(1)
    */

    public class _01_LinearSearch
    {
        public static int Execute<T>(T[] values, T query)
        {
            if (values == null || values.Count() < 1)
                return -1;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].Equals(query))
                    return i;
            }

            return -1;
        }
    }
}