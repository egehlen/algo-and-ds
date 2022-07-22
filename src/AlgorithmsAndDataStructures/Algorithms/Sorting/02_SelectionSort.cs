namespace AlgorithmsAndDataStructures.Algorithms.Sorting
{
    /*
        Selection sort
        ==============

        It works by selecting the smallest element from an unsorted array and moving it
        to the front. Then it scans through all the items (from left to right) to find
        the smallest one and move it to the front. With the first item sorted, it will 
        repeat the process over the unsorted items until all items are sorted.
        
        Time complexity (worst): O(n^2)
        Space complexity: O(1)
    */

    public class _02_SelectionSort
    {
        public static T[] Execute<T>(T[] values)
        {
            for (int i = 0; i < values.Count(); i++)
            {
                var lowest = i;

                for (int j = i + 1; j < values.Count(); j++)
                {
                    if (Utility.Compare(values[j], values[lowest]))
                        lowest = j;
                }

                Utility.SwapItems(values, i, lowest);
            }

            return values;
        }
    }
}
