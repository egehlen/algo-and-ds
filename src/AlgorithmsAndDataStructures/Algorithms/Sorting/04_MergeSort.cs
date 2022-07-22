namespace AlgorithmsAndDataStructures.Algorithms.Sorting
{
    public class _04_MergeSort
    {

        public static T[] Merge<T>(T[] valuesA, T[] valuesB)
        {
            if (valuesA == null || valuesB == null || valuesA.Length == 0 || valuesB.Length == 0)
                return new T[] { };

            var result = new List<T>();
            var i = 0;
            var j = 0;

            // Iterate over each item of both arrays to
            // check if one is less than the other element
            // and then add the smaller one to the result
            while (i < valuesA.Length && j < valuesB.Length)
            {
                if (Utility.Compare(valuesA[i], valuesB[j]))
                {
                    result.Add(valuesA[i]);
                    i++;
                }
                else
                {
                    result.Add(valuesB[j]);
                    j++;
                }
            }

            // Add to result what is left in valuesA
            while (i < valuesA.Length)
            {
                result.Add(valuesA[i]);
                i++;
            }

            // Add to result what is left in valuesB
            while (j < valuesB.Length)
            {
                result.Add(valuesB[j]);
                j++;
            }

            return result.ToArray();
        }

        public static T[] Execute<T>(T[] values)
        {
            if (values.Length <= 1)
                return values;

            var middleIndex = (int)Math.Floor((double)values.Length / 2);
            var leftSection = Execute<T>(values.SkipLast(values.Length - middleIndex).ToArray());
            var rightSection = Execute<T>(values.Skip(middleIndex).ToArray());

            return Merge(leftSection, rightSection);
        }
    }
}
