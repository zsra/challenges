class Solution {

  public int search(int[] nums, int target) {
    if (nums.length == 0) return -1;

    if (nums.length == 1) {
      if (nums[0] == target) {
        return 0;
      } else {
        return -1;
      }
    }

    if (target >= nums[0]) {
      int index = -1;
      do {
        if (target == nums[index + 1]) {
          return index + 1;
        }

        index++;
      } while (index + 1 <= nums.length - 1 && nums[index] < nums[index + 1]);
    } else {
      int index = nums.length;
      do {
        if (target == nums[index - 1]) {
          return index - 1;
        }

        index--;
      } while (index - 1 >= 0 && nums[index] > nums[index - 1]);
    }

    return -1;
  }
}
