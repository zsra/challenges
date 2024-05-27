public class Solution {
    public int SpecialArray(int[] nums) 
    {
        Array.Sort(nums);
        int x = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            while (x <= nums[i])
            {
                if (nums.Length - i == x) 
                {
                    return x;
                }
                    
                x++;
            }
        }

        return -1;
    }
}