public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        var remainders = new int[k];
        remainders[0]++;

        var sum = 0;
        var ans = 0;
        foreach (var num in nums)
        {
            sum += num;
            var remainder = (sum % k + k) % k;
            ans += remainders[remainder];

            remainders[remainder]++;
        }

        return ans;
    }
}