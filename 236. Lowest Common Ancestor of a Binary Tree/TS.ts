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

function lowestCommonAncestor(root: TreeNode | null, p: TreeNode | null, q: TreeNode | null): TreeNode | null {
	return recursive(root, p, q);
};

function recursive(root: TreeNode|null, p: TreeNode|null, q: TreeNode|null): TreeNode | null {
    if (root === null) return root;
    if (root === p || root === q) return root;
    const left = recursive(root.left, p, q);
    const right = recursive(root.right, p, q);
    if (left && right) return root;
    if (left) return left;
    else return right;
}