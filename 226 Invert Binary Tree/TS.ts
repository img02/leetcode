/**
 * Definition for a binary tree node.
 * class TreeNode {
 *     val: number
 *     left: TreeNode | null
 *     right: TreeNode | null
 *     constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
 *         this.val = (val===undefined ? 0 : val)
 *         this.left = (left===undefined ? null : left)
 *         this.right = (right===undefined ? null : right)
 *     }
 * }
 */

function invertTree(root: TreeNode | null): TreeNode | null {
    //bfs(root);
    //dfs_iterative(root);
    dfs_recursive(root);
    return root;
};

function bfs(root: TreeNode | null): void{
    const q = [root];

    while(q.length > 0){
        const node = q.shift();
        if (node == null) continue;
        [node.left, node.right] = [node.right, node.left];
        q.push(node.left);
        q.push(node.right);
    }    
}

function dfs_iterative(root: TreeNode | null): void{
    const s = [root];
    while (s.length > 0){
        const node = s.pop();
        if (node === null) continue;

        [node.left, node.right] = [node.right, node.left];
        s.push(node.left);
        s.push(node.right);
    }
}

function dfs_recursive(root: TreeNode | null): void{
    if (root === null) return;

    [root.left, root.right] = [root.right, root.left];
    dfs_recursive(root.left);
    dfs_recursive(root.right);    
}