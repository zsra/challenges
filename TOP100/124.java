class Solution {

  private int maxValue = Integer.MIN_VALUE;

  public int maxPathSumHelper(TreeNode root) {
    int l = 0;
    int r = 0;
    if (root.left != null) {
      l = maxPathSumHelper(root.left);
      l = l >= 0 ? l : 0;
    }
    if (root.right != null) {
      r = maxPathSumHelper(root.right);
      r = r >= 0 ? r : 0;
    }

    maxValue = Math.max(maxValue, root.val + l + r);

    return root.val + Math.max(l, r);
  }

  public int maxPathSum(TreeNode root) {
    maxPathSumHelper(root);

    return maxValue;
  }
}
