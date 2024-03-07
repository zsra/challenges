class Solution {

  public int findMin(int[] nums) {
    if (nums.length == 1) {
      return nums[0];
    }

    int low = 0;
    int high = nums.length - 1;
    int mid = 0;

    while (low <= high) {
      mid = high + (low - high) / 2;

      if (mid - 1 >= 0 && nums[mid] < nums[mid - 1]) {
        return nums[mid];
      }

      if (nums[high] < nums[mid]) {
        low = mid + 1;
      } else {
        high = mid - 1;
      }
    }

    return nums[0];
  }
}
