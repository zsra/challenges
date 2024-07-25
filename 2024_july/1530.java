public class Solution {
    public int countPairs(TreeNode root, int distance) {
        int[] ans = new int[1];

        dfs(root, distance, ans);
        return ans[0];
    }

    private int[] dfs(TreeNode node, int distance, int[] ans) {
        if (node == null) return new int[0];
        if (node.left == null && node.right == null) return new int[]{0};

        int[] leftDistances = dfs(node.left, distance, ans);
        int[] rightDistances = dfs(node.right, distance, ans);

        for (int l : leftDistances) {
            for (int r : rightDistances) {
                if (l + r + 2 <= distance) ans[0]++;
            }
        }

        int[] distances = new int[leftDistances.length + rightDistances.length];
        int index = 0;
        for (int l : leftDistances) distances[index++] = l + 1;
        for (int r : rightDistances) distances[index++] = r + 1;
        return distances;
    }
}