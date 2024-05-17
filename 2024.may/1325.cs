public TreeNode RemoveLeafNodes(TreeNode root, int target) 
{
    if (root == null) 
    {
        return null;
    }

    root.left = RemoveLeafNodes(root.left, target);
    root.right = RemoveLeafNodes(root.right, target);

    if (root.val == target && root.left == null && root.right == null) 
    {
        return null;
    }

    return root;
}