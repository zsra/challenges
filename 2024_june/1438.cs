public class Solution
{
    public int LongestSubarray(int[] nums, int limit)
    {
        int n = nums.Length;
        int i = 0;
        int j = 0;
        Dictionary<int, int> dict = new();

        int length = 0;
        while (j < n)
        {
            if (!dict.ContainsKey(nums[j]))
            {
                dict.Add(nums[j], 1);
            }
            else
            {
                dict[nums[j]]++;
            }

            int min = dict.Keys.Min();
            int max = dict.Keys.Max();

            while (max - min > limit)
            {
                dict[nums[i]]--;

                if (dict[nums[i]] == 0)
                {
                    dict.Remove(nums[i]);
                }

                min = dict.Keys.Min();
                max = dict.Keys.Max();
                i++;
            }

            length = Math.Max(length, j - i + 1);
            j++;
        }

        return length;
    }
}
