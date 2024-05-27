public long MaximumHappinessSum(int[] happiness, int k)
{
    Array.Sort(happiness, Comparer<int>.Create((x, y) => y.CompareTo(x)));
    long maxHappiness = 0;
    int added = -1;

    for (int i = 0; i < k; i++)
    {
        maxHappiness += happiness[i];

        if (happiness.Length > i + 1 && happiness[i + 1] >= added)
        {
            happiness[i + 1] += added;
            added += -1;
        }
        
        if (happiness.Length <= i + 1 || happiness[i + 1] <= 0) {
            break;
        }
    }

    return maxHappiness;
}