public class Solution {
    public IList<int> LargestValues(TreeNode root) {
        if (root == null) return new List<int>();
        
        List<int> result = new List<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Count > 0) {
            int curr_level_size = queue.Count;
            int max_val = Int32.MinValue;
            
            for (int i = 0; i < curr_level_size; i++) {
                TreeNode node = queue.Dequeue();
                max_val = Math.Max(max_val, node.val);
                
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            
            result.Add(max_val);
        }
        
        return result;
    }
}