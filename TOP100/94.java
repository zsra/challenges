class Solution {

  public List<Integer> inorderTraversal(TreeNode root) {
    List<Integer> collector = new ArrayList<>();
    inorderTraversalHelper(root, collector);

    return collector;
  }

  public void inorderTraversalHelper(TreeNode root, List<Integer> collector) {
    if (root == null) {
      return;
    }

    inorderTraversalHelper(root.left, collector);
    collector.add(root.val);
    inorderTraversalHelper(root.right, collector);
  }
}
