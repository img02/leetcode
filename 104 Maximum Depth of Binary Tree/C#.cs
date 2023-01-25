/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode root) {
        return Iterative(root);
        //return Recursive(root, 0);
    }

    private int Iterative(TreeNode root) { //BFS
        if (root == null) return 0;

        var depth = 0;
        var q = new Queue<TreeNode>();                
        q.Enqueue(root);

        while (q.Count() != 0)
        {
            depth++;
            var nodeCount = q.Count();
            for (; nodeCount > 0; nodeCount--)
            {
                root = q.Dequeue();
                if (root.left != null) q.Enqueue(root.left);
                if (root.right != null) q.Enqueue(root.right);
            }
        }
        return depth;
    }


    private int Recursive(TreeNode root, int depth) { //DFS
        if (root == null) return depth;

        (var left, var right) = (Recursive(root.left, depth + 1), Recursive(root.right, depth + 1));
        return left > right ? left : right;
    }
}