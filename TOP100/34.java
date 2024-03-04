class Solution {

  public int[] searchRange(int[] nums, int target) {
    int first = findFirst(nums, target);
    int last = findLast(nums, target);

    return new int[] { first, last };
  }

  public int findFirst(int[] nums, int target) {
    int low = 0;
    int high = nums.length - 1;
    int middle;
    int first = -1;

    while (low <= high) {
      middle = low + (high - low) / 2;

      if (nums[middle] == target) {
        first = middle;
        high = middle - 1;
      } else if (nums[middle] < target) {
        low = middle + 1;
      } else {
        high = middle - 1;
      }
    }

    return first;
  }

  public int findLast(int[] nums, int target) {
    int low = 0;
    int high = nums.length - 1;
    int middle;
    int last = -1;

    while (low <= high) {
      middle = low + (high - low) / 2;

      if (nums[middle] == target) {
        last = middle;
        low = middle + 1;
      } else if (nums[middle] < target) {
        low = middle + 1;
      } else {
        high = middle - 1;
      }
    }

    return last;
  }
}
