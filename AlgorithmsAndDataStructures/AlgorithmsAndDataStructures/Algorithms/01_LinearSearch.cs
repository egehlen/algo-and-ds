namespace AlgorithmsAndDataStructures.Algorithms
{
    /*
        Time complexity:
            - Best: O(1) => when the value matches occurs in the first element
            - Worst/avg: O(n) => varies according the length of the input

        Space complexity:
            - Best/worst/avg: O(1) => no allocations done for the algorithm
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