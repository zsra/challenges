public class Solution {
    public bool IsSubPath(ListNode head, TreeNode root) {
        if(head == null) return true;
        if(root == null) return false;
        return DFS(head, root) || IsSubPath(head, root.left) || IsSubPath(head, root.right);
    }

    private bool DFS(ListNode head, TreeNode root)
    {
        if(head == null) return true;
        if(root == null) return false;
        return head.val == root.val && (DFS(head.next, root.left) || DFS(head.next, root.right));
    }
}