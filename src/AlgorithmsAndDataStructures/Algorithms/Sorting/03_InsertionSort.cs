namespace AlgorithmsAndDataStructures.Algorithms.Sorting
{
    /*
    
        Insertion sort
        --------------

        It works by comparing values in turn, starting with the second value in the list.
        If this value is greater than the value to the left of it, no changes are made.
        Otherwise this value is repeatedly moved left until it meets a value that is less
        than it. The sort process then starts again with the next value. This continues
        until the end of the list is reached.

        Time complexity:
            - Best: O(n)
            - Worst/avg: O(n^2)
     
        Space complexity:
            - Best/worst/avg: O(1)

    */

    public class _03_InsertionSort
    {
        public static T[] Execute<T>(T[] values)
        {
            for (int i = 1; i < values.Count(); i++)
            {
                var currentValue = values[i];
                int j;

                for (j = i - 1; j >= 0 && Utility.Compare(currentValue, values[j]); j--)
                {
                    values[j + 1] = values[j];
                }

                values[j + 1] = currentValue;
            }

            return values;
        }
    }
}
