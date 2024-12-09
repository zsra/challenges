using System.Runtime.CompilerServices;
public class Solution {
    [SkipLocalsInit]
    public unsafe bool[] IsArraySpecial(int[] nums, int[][] queries) {
        var prefix = stackalloc int[nums.Length];
        var prev = *prefix = 0;
        var sum = prev;
        for (var i = 0; i < nums.Length; ++i) {
            var n = nums[i] & 1;
            prefix[i] = sum += n ^ prev;
            prev = n;
        }

        var res = new bool[queries.Length];
        for (var i = 0; i < queries.Length; ++i) {
            var q = queries[i];
            var (left, right) = (q[0], q[1]);
            res[i] = (prefix[right] - prefix[left]) == right - left;
        }
        return res;
    }
}