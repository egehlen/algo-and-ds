namespace AlgorithmsAndDataStructures.Algorithms.Sorting
{
    /*
        Bubble sort
        -----------

        It Works by comparing two elements on each iteration and swapping them if 
        out of order, until it reaches the end of the collection. For example, in 
        an array of integers, each loop pass will check the current element against 
        the next element. If the first element is a higer number, it will swap with 
        the second one, repeating the process until it reaches the end of the 
        collection and starting again from the current + 1 element, therefore pushing 
        the bigger number to the end of the collection.

        Time complexity:
            - Best: O(n)
            - Worst/avg: O(n^2)

        Space complexity:
            - Best/worst/avg: O(1)
     
    */

    public class _01_BubbleSort
    {
        public static int[] Execute(int[] values)
        {
            bool noSwaps;

            for (int i = values.Count(); i > 0; i--)
            {
                noSwaps = true;

                for (int j = 0; j < values.Count() - 1; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        Utility.SwapItems(values, j, (j + 1));
                        noSwaps = false;
                    }
                }

                if (noSwaps) break;
            }

            return values;
        }

        public static string[] Execute(string[] values)
        {
            bool noSwaps;

            for (int i = values.Count(); i > 0; i--)
            {
                noSwaps = true;

                for (int j = 0; j < values.Count() - 1; j++)
                {
                    if (values[j].CompareTo(values[j + 1]) > 0)
                    {
                        Utility.SwapItems(values, j, (j + 1));
                        noSwaps = false;
                    }
                }

                if (noSwaps) break;
            }

            return values;
        }
    }
}