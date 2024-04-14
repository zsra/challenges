var sum;

var sumOfLeftLeaves = function(root) {
    sum = 0;
    sumOfLeftLeavesRecursive(root, true)
    return sum;
};

var sumOfLeftLeavesRecursive = function(root, isLeft) {
    
    if (isLeft && root.left == null && root.right == null) {
        sum += root.val;
    }
    
    if (root.left != null) {
        sumOfLeftLeavesRecursive(root.left, true);
    }
    
    if (root.right != null) { 
        sumOfLeftLeavesRecursive(root.right, false);
    }
};

