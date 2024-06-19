public class Solution
{
    bool CanBeMade(int[] days, int day, int k, int m)
    {
        int count = 0;
        int bcount = 0;
        for(int i = 0; i < days.Length; i++)
        {
            if (days[i] > day)
            {
                count = 0;
            } 
            else
            {
                count++;
            }
            if(count == k) {
                bcount++;
                count = 0;
            }
        }
        if(bcount >= m) return true;
        return false;
    }

    public int MinDays(int[] bloomDay, int m, int k)
    {
        if ((long)m * k > bloomDay.Length) return -1;
        int l = 1, h = int.MinValue;
        for(int i = 0; i < bloomDay.Length; i++)
        {
            h = Math.Max(h, bloomDay[i]);
        }
        int ans = 0;
        while(l <= h)
        {
            int mid = (l + h) / 2;

            if(CanBeMade(bloomDay, mid, k, m) == true)
            {
                ans = mid;
                h = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
        }
        return ans;
    }
}