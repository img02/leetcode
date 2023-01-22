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
    public int KthSmallest(TreeNode root, int k) 
    {
        //return Iterative(root, k);
        (k, var result) =  Recursive(root, k, -1);
        return result;
    }

    private int Iterative(TreeNode root, int k)
    {
        var stack = new Stack<TreeNode>();

        while (root != null || stack.Count != 0)
        {
            // go all the way down left, adding to stack
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            // get last node, decrement k, if 0 - return value
            root = stack.Pop();
            k--;
            if (k == 0)
            {
                return root.val;
            }

            // else go down right node, repeat
            root = root.right;
        }
        return -1;
    }

    private (int index, int value) Recursive(TreeNode root, int k, int kthValue)
    {
        if (root == null){
            return (k, kthValue);
        }

        // go down left
        (k, kthValue) = Recursive(root.left, k, kthValue);
        // if kthValue has been found, return it
        if (kthValue != -1) {
            return (k, kthValue);
        }
        // else decrement k, if now 0, node kth smallest node found
        k--;
        if (k == 0) 
        {
            return (k, root.val);
        }
        // else try right node, then repeat
        (k, kthValue) = Recursive(root.right, k, kthValue);
        return (k, kthValue);
    }
}