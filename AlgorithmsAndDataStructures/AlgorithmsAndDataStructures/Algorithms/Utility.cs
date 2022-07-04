namespace AlgorithmsAndDataStructures.Algorithms
{
    public static class Utility
    {
        public static void SwapItems<T>(T[] values, int indexA, int indexB)
        {
            var temp = values[indexA];
            values[indexA] = values[indexB];
            values[indexB] = temp;
        }
    }
}
