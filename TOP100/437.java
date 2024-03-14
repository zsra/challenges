class Solution {

  long counter = 0;

  public int pathSum(TreeNode root, long sum) {
    if (root == null) return 0;

    pathSumHelper(root, sum, 0);
    pathSum(root.left, sum);
    pathSum(root.right, sum);

    return (int)counter;
  }

  void pathSumHelper(TreeNode root, long sum, long currentSum) {
    if (root == null) {
      return;
    }
    currentSum += root.val;
    if (currentSum == sum) {
      counter++;
    }
    pathSumHelper(root.left, sum, currentSum);
    pathSumHelper(root.right, sum, currentSum);
  }
}
