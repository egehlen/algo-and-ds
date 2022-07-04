namespace AlgorithmsAndDataStructures.Algorithms.Sorting
{
    /*
    
        Time complexity:
            - Best: O(n)
            - Worst/avg: O(n^2)
     
        Space complexity:
            - Best/worst/avg: O(1)

    */

    public class _03_InsertionSort
    {
        public static int[] Execute(int[] values)
        {
            for (int i = 1; i < values.Count(); i++)
            {
                var currentValue = values[i];
                int j;

                for (j = i - 1; j >= 0 && values[j] > currentValue; j--)
                {
                    values[j + 1] = values[j];
                }

                values[j + 1] = currentValue;
            }


            return values;
        }
    }
}
