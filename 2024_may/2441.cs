public int FindMaxK(int[] nums)
{
    int max = -1;
    HashSet<int> collector = new();

    for (int i = 0; i < nums.Length; i++)
    {
        collector.Add(nums[i]);

        if (collector.TryGetValue(nums[i] * -1, out int _))
        {
            int a = Math.Abs(nums[i]);

            if ( a > max)
            {
                max = a;
            }
        }
    }

    return max;
}