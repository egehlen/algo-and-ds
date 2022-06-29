namespace AlgorithmsAndDataStructures.Algorithms
{
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