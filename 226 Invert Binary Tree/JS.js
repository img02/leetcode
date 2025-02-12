/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {TreeNode}
 */
var invertTree = function(root) {
    //bfs(root); 
    //dfs_iterative(root);
    recursiveInvert(root);
    return root;
};

function bfs(root){
    const q = [root];

    while (q.length > 0){
        const node = q.shift();
        if (node === null) continue;
        [node.left, node.right] = [node.right, node.left];
        q.push(node.left);
        q.push(node.right);        
    }
}

function dfs_iterative(root){
    const stack = [root];

    while (stack.length > 0){
        const node = stack.pop()
        if (node === null) continue;
        stack.push(node.left, node.right);        
        const temp = node.left
        node.left = node.right;
        node.right = temp;        
    }
}


function dfs_recursive(root){
    if (root === null) return;
    
    const temp = root.left;
    root.left = root.right;
    root.right = temp;
    dfs_recursive(root.left);
    dfs_recursive(root.right);
}