class Solution {

  public boolean isValidBST(TreeNode root) {
    return isValidBSTHelper(root, Long.MIN_VALUE, Long.MAX_VALUE);
  }

  public boolean isValidBSTHelper(TreeNode root, long minVal, long maxVal) {
    if (root == null) return true;
    if (root.val >= maxVal || root.val <= minVal) return false;
    return (
      isValidBSTHelper(root.left, minVal, root.val) &&
      isValidBSTHelper(root.right, root.val, maxVal)
    );
  }
}
