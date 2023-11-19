namespace CountingSort;

/* -----------------------------------------------------------------------------
    Counting Sort Algorithm

    Big O notation
    - Space complexity O(k)
    - Average-case Time complexity O(n+k)
----------------------------------------------------------------------------- */

public static class CountingSort
{
    public static int[] Sort(int[] array)
    {
        var min = array.Min();
        var max = array.Max();
        var occurrences = new int[max - min + 1];

        for (var i = 0; i < array.Length; i++)
        {
            occurrences[array[i] - min]++;
        }

        for (var i = 1; i < occurrences.Length; i++)
        {
            occurrences[i] += occurrences[i - 1];
        }

        var sorted = new int[array.Length];

        for (var i = array.Length - 1; i >= 0; i--)
        {
            sorted[occurrences[array[i] - min] - 1] = array[i];
            occurrences[array[i] - min]--;
        }

        return sorted;
    }
}