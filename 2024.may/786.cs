public int[] KthSmallestPrimeFraction(int[] arr, int k)
{
    List<int[]> fractions = new();

    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            fractions.Add([arr[i], arr[j]]);
        }
    }

    fractions.Sort((a, b) => a[0] * b[1] - a[1] * b[0]);

    return fractions[k - 1];
}