/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @param {TreeNode} p
 * @param {TreeNode} q
 * @return {TreeNode}
 */
var lowestCommonAncestor = function(root, p, q) {
    return recursive(root, p, q);
};

function recursive(root, p, q){
    if (root === null) return root;
    if (root == p || root == q) return root;
    const left = recursive(root.left, p, q);
    const right = recursive(root.right, p, q);
    if (right && left) return root;
    if (left) return left
    else return right
}