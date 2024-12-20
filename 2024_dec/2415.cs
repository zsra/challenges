public class Solution {
    public TreeNode ReverseOddLevels(TreeNode root) {
        if (root == null) return null;
        ReverseOddLevelsHelper(root.left, root.right, 1);

        return root;
    }
    private void ReverseOddLevelsHelper(TreeNode left, TreeNode right, int level) {
        if (left == null || right == null) return;

        if (level % 2 == 1) {
            int temp = left.val;
            left.val = right.val;
            right.val = temp;
        }
        ReverseOddLevelsHelper(left.left, right.right, level + 1);
        ReverseOddLevelsHelper(left.right, right.left, level + 1);
    }
}