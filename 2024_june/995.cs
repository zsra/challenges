public class Solution
{
    public int MinKBitFlips(int[] nums, int k)
    {
        var count = 0;
        int flip = 0;
        if (k > nums.Length)
        {
            return -1;
        }
        for (var i = 0; i < nums.Length; i++)
        {
            if (i >= k)
            {
                flip ^= 1 - nums[i - k];
            }
            if (nums[i] == flip)
            {
                if (i + k > nums.Length)
                {
                    return -1;
                }
                nums[i] = 0;
                flip ^= 1;
                count++;
            }
            else
            {
                nums[i] = 1;
            }
        }
        return count;
    }
}
