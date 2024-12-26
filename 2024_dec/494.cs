public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
        var memo = new Dictionary<(int, int), int>();
        return CalculateWays(nums, target, 0, 0, memo);
    }

    private int CalculateWays(int[] nums, int target, int index, int currentSum, Dictionary<(int, int), int> memo) {
        if (index == nums.Length) {
            return currentSum == target ? 1 : 0;
        }

        if (memo.ContainsKey((index, currentSum))) {
            return memo[(index, currentSum)];
        }

        int add = CalculateWays(nums, target, index + 1, currentSum + nums[index], memo);
        int subtract = CalculateWays(nums, target, index + 1, currentSum - nums[index], memo);

        memo[(index, currentSum)] = add + subtract;

        return memo[(index, currentSum)];
    }
}