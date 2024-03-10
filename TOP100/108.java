class Solution {

  public TreeNode sortedArrayToBST(int[] nums) {
    return sortedArrayToBSTHeler(nums, 0, nums.length - 1);
  }

  public TreeNode sortedArrayToBSTHeler(int[] nums, int start, int end) {
    if (start > end) {
      return null;
    }

    int mid = start + (end - start) / 2;

    TreeNode node = new TreeNode(nums[mid]);

    node.left = sortedArrayToBSTHeler(nums, start, mid - 1);
    node.right = sortedArrayToBSTHeler(nums, mid + 1, end);

    return node;
  }
}
