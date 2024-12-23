
public class Solution {
    public int MinimumOperations(TreeNode root)
    {
        int ans = 0;
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int count = queue.Count;
        List<int> li = new();
        List<int> inds = new();
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node.left != null) queue.Enqueue(node.left);
            if (node.right != null) queue.Enqueue(node.right);
            inds.Add(li.Count);
            li.Add(node.val);
            count--;
            if (count == 0)
            {
                count = queue.Count;
                var keys = li.ToArray();
                var items = inds.ToArray();
                Array.Sort(keys, items);
                HashSet<int> set = new();
                for (int i = 0; i < items.Length; i++)
                {
                    if (set.Contains(i)) continue;
                    if (items[i] == i) continue;
                    int start = i;
                    int next = items[i];
                    while (start != next)
                    {
                        set.Add(next);
                        next = items[next];
                        ans++;
                    }
                }
                inds.Clear();
                li.Clear();
            }
        }
        return ans;
    }
}