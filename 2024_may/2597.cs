public class Solution {
    private Dictionary<int, int> map = new Dictionary<int, int>();
    private int res;

    public int BeautifulSubsets(int[] nums, int k) {
       int l = nums.Length;

       if(l == 1)
       {
           return 1;
       }

       if(l == 2)
       {
           int abs = nums[0] - nums[1];
           if(abs == k || abs == -k)
              return 2;

           return 3;
       }

       Helper(nums, l, k, 0);
       return res;

    }

    private void Helper(int[] nums, int l, int k, int start)
    {
        if (map.Count != 0)
        {
            res++;
        }
        for (int i = start; i < l; i++)
        {
            if (map.ContainsKey(nums[i] - k) || map.ContainsKey(nums[i] + k))
            {
                continue;
            }
            map[nums[i]] = map.GetValueOrDefault(nums[i], 0) + 1;

            Helper(nums, l, k, i + 1);

            map[nums[i]] = map[nums[i]] - 1;

            if (map[nums[i]] == 0)
            {
                map.Remove(nums[i]);
            }
        }
    }

}