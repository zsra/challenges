using System.Runtime.Intrinsics.X86;
public partial class Solution {
    public unsafe int MaximumLength(string s) {
        var stride = s.Length + 1;
        fixed (byte* counts = new byte[27 * stride]) {
            var masks = stackalloc ulong[27];
            var set = 0U;
            for (var i = 0; i < s.Length;) {
                var curr = s[i];
                var len = 1;
                for (++i; i < s.Length && s[i] == curr; ++i, ++len) ;
                var idx = curr & 0x1F;
                ++counts[idx * stride + len];
                masks[idx] |= 1UL << len;
                set |= 1U << idx;
            }

            var max = -1;
            for (var setBits = set; setBits != 0; setBits = Bmi1.ResetLowestSetBit(setBits)) {
                var idx = (int)Bmi1.TrailingZeroCount(setBits);
                var mask = masks[idx];
                var highestLen = BitOperations.Log2(mask);
                var nextLen = BitOperations.Log2(mask ^ 1UL << highestLen);
                var lenCounts = counts + stride * idx;
                var highestCount = lenCounts[highestLen];
                var nextCount = lenCounts[nextLen];
                var possibleRepeatedLen = highestLen - (highestCount - 2 >>> 31) - (highestCount - 3 >>> 31);
                max = Math.Max(max, Math.Max(possibleRepeatedLen, nextLen));
            }
            return max | max - 1 >> 31;
        }
    }
}