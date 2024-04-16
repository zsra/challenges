var addOneRow = function(root, v, depth) {
    if (depth === 1) return new TreeNode(v, root, null)
    if (depth === 2) {
        root.left = new TreeNode(v, root.left, null)
        root.right = new TreeNode(v, null, root.right)
    } else {
        if (root.left) addOneRow(root.left, v, depth-1)
        if (root.right) addOneRow(root.right, v, depth-1)
    }
    return root
};