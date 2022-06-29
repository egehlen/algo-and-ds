using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Algorithms
{
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
    }
}
