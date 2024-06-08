public class Solution
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> map = new Dictionary<int, int>() { { 0, -1 } };
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (k > 0)
            {
                sum = sum % k;
                if (map.ContainsKey(sum))
                {
                    if (i - map[sum] > 1)
                    {
                        return true;
                    }
                }
                else
                {
                    map[sum] = i;
                }
            }
        }

        return false;
    }
}
