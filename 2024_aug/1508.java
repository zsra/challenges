class Solution {
    public int rangeSum(int[] nums, int n, int left, int right) {
        List<Integer> sums = GetSubArraySums(nums);
        long result = 0;

        sums.sort(Integer::compareTo);

        for (int i = left - 1; i < right; i++) {
            result += sums.get(i);
        }

        return (int)(result % 1000000007);
    }

    private static List<Integer> GetSubArraySums(int[] nums) {
        List<Integer> sums = new ArrayList<>();

        for (int start = 0; start < nums.length; start++) {
            int sum = 0;
            for (int end = start; end < nums.length; end++) {
                sum += nums[end];
                sums.add(sum);
            }
        }

        return sums;
    }
}