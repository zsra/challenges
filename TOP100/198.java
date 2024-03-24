class Solution {

  public int rob(int[] nums) {
    int prev_one = 0;
    int prev_two = 0;

    for (int i = 0; i < nums.length; i++) {
      int temp = prev_one;
      if (prev_two + nums[i] > prev_one) {
        prev_one = prev_two + nums[i];
      }
      prev_two = temp;
    }

    return prev_one;
  }
}
