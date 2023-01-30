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
        //return Iterative(root, p , q);
        return Recursive(root, p, q);
    }

    private TreeNode Iterative(TreeNode root, TreeNode p, TreeNode q) {
        while (true) {
            if (root.val > p.val && root.val > q.val) root = root.left;
            else if (root.val < p.val && root.val < q.val) root = root.right;
            else return root;
        }
    }

    private TreeNode Recursive(TreeNode root, TreeNode p, TreeNode q) {
        if (root.val > p.val && root.val > q.val) return Recursive(root.left, p, q);
        if (root.val < p.val && root.val < q.val) return Recursive(root.right, p, q);
        return root;
    }
}