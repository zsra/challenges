public class Solution {
    private int moves = 0;

    public int DistributeCoins(TreeNode root) {
        Dfs(root);
        return moves;
    }

    private int Dfs(TreeNode node) {
        if (node == null) return 0;
        
        int leftExcess = Dfs(node.left);
        int rightExcess = Dfs(node.right);
        moves += Math.Abs(leftExcess) + Math.Abs(rightExcess);
        
        return node.val + leftExcess + rightExcess - 1;
    }
}