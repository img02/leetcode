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
    public bool IsValidBST(TreeNode root) {
        return Iterative(root);
        //return Recursive(root, Int64.MinValue, Int64.MaxValue);
    }

    
    private bool Iterative(TreeNode root)
    {
        // using stack for LIFO
        var stack = new Stack<TreeNode>();
        TreeNode prevNode = null;

        while (root != null || stack.Count != 0)
        {   
            while (root != null){                
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();

            // since we go down left side first,
            // the 'previous node' value from stack
            // will always be smaller than current node value
            // as we go down the right side,
            // the node value last popped off stack must be 
            // either from the current nodes left subtree -- therefore smaller
            // or a parent node of this node,
            // which means thisnode is part of the right subtree -- and therefore larger that prev node
            if (prevNode != null && prevNode.val >= root.val) return false;

            prevNode = root;
            root = root.right;            
        }
        return true;
    }


    // node value is  -2^31 <= Node.val <= 2^31 - 1
    // which is int32 min/max
    // so int64 must be used
    // initally these must be smaller and larger than possible min/max node values
    private bool Recursive(TreeNode root, long min, long max)
    {
        if (root == null) return true;

        //if current node value is larger current max node value
        //or smaller than current min node value, not valid BST
        if (root.val >= max || root.val <= min) return false;

        // go down left node, min value is same, max value is current nodes value
        // as left node value must be smaller than current value
        return Recursive(root.left, min, root.val) &&
        // go down right node, min value is current node value
        // as right node value must be larger 
        Recursive(root.right, root.val, max);
    }
}