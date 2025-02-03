/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
 func lowestCommonAncestor(root, p, q *TreeNode) *TreeNode {
  return recursive(root, p, q)
}

func recursive(root, p, q *TreeNode) *TreeNode {
    if root == nil{
         return root;
    }
    if root == p || root == q {
         return root;
    }
    var left = recursive(root.Left, p, q);
    var right = recursive(root.Right, p, q);
    if right != nil && left != nil {
         return root;
    }
    if left != nil {
         return left;
    } else {
         return right;
    }
}