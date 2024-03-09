class Solution {

  private int level = 0;

  public int maxDepth(TreeNode root) {
    maxDepthHelper(root, 0);

    return level;
  }

  public void maxDepthHelper(TreeNode root, int l) {
    if (root == null) {
      return;
    }
    if (root.left != null) {
      maxDepthHelper(root.left, l + 1);
    }
    if (root.right != null) {
      maxDepthHelper(root.right, l + 1);
    }

    if (level < l + 1) {
      level = l + 1;
    }
  }
}
