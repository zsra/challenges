var smallestFromLeaf = function(root) {
    let list = [];
    let str = "";
    inorder(root, str);
    function inorder(root, str) {
        if(root == null) return;
        let temp = String.fromCharCode(97+root.val) + str;
        if(root.left == null && root.right==null) list.push(temp);
        inorder(root.left, temp);
        inorder(root.right, temp);
    };
    list.sort();
    return list[0];
};