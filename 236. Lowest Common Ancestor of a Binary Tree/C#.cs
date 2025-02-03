/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        return Recursive(root, p, q);
    } 

    private TreeNode Recursive(TreeNode root, TreeNode p, TreeNode q){
        if (root == null) return root;

        if (root == p || root == q) return root;

        var left = Recursive(root.left, p, q);
        var right = Recursive(root.right, p, q);

        if (left != null && right != null) return root;
        if (left == null) return right;
        else return left;
    }
}

