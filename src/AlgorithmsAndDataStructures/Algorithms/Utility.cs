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

        public static bool Compare<T>(T? valueA, T? valueB)
        {
            if (valueA == null || valueB == null)
                return false;

            if (typeof(T) == typeof(int))
                return (int)Convert.ChangeType(valueA, typeof(int)) < (int)Convert.ChangeType(valueB, typeof(int));

            if (typeof(T) == typeof(string))
                return String.Compare((string)Convert.ChangeType(valueA, typeof(string)), (string)Convert.ChangeType(valueB, typeof(string))) < 0;

            throw new NotImplementedException();
        }

        public static T[] Push<T>(this T[] array, T value)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = value;
            return array;
        }
    }
}
