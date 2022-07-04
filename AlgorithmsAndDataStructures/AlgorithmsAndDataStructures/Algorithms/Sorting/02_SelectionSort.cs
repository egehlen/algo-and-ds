namespace AlgorithmsAndDataStructures.Algorithms.Sorting
{
    /*
    
        Works by comparing each element with the first unsorted to determine the minimum and then swap the values
        
        Time complexity:
            - Best: O(n)
            - Worst/avg: O(n^2)

        Space complexity:
            - Best/worst/avg: O(1)
     
    */
    public class _02_SelectionSort
    {
        public static int[] Execute(int[] values)
        {
            for (int i = 0; i < values.Count(); i++)
            {
                var lowest = i;

                for (int j = i + 1; j < values.Count(); j++)
                {
                    if (values[j] < values[lowest])
                        lowest = j;
                }

                Utility.SwapItems(values, i, lowest);
            }

            return values;
        }

        public static string[] Execute(string[] values)
        {
            for (int i = 0; i < values.Count(); i++)
            {
                var lowest = i;

                for (int j = i + 1; j < values.Count(); j++)
                {
                    if (values[j].CompareTo(values[lowest]) < 0)
                        lowest = j;
                }

                Utility.SwapItems(values, i, lowest);
            }

            return values;
        }
    }
}
