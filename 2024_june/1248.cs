public class Solution
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        dic[0] = 1;

        int count = 0;

        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum = sum + nums[i] % 2;

            int rem = sum - k;

            if (dic.ContainsKey(rem))
                count += dic[rem];

            if (dic.ContainsKey(sum))
                dic[sum]++;
            else
                dic[sum] = 1;
        }

        return count;
    }
}
