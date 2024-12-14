public class Solution 
{
    public long ContinuousSubarrays(int[] nums) 
    {       
        int left = 0;
        int right = 0;
        long answer = 0;
        SortedList<int,int> ss = new();

        while (right < nums.Length)
        {

            if (!ss.ContainsKey(nums[right]))
            {
                ss.Add(nums[right],0);
            }

            ss[nums[right]]++;

            int max = ss.Keys.Max();
            int min = ss.Keys.Min();

            while (Math.Abs(max-min) > 2)
            {   
                ss[nums[left]]--;

                if (ss[nums[left]]==0)
                {
                    ss.Remove(nums[left]);
                }

                left++;
                max = ss.Keys.Max();
                min = ss.Keys.Min();
            }

            answer += (right-left)+1;
            right++;
        }

        return answer;

    }
}