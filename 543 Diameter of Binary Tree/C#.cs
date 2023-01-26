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
    public int DiameterOfBinaryTree(TreeNode root) {
        return Iterative(root);
        /*
        var diameter = 0;
        Recursive(root, ref diameter);
        return diameter;
        */
    }

    private int Iterative(TreeNode root) {
        if (root == null) return 0;        
        var diameter = 0;
        var nodeEdges = new Dictionary<TreeNode, int>();
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        
        while (stack.Count > 0)
        {   // peek to get latest added node and check its child nodes
            root = stack.Peek();
            // if child node exists, and doesn't exist in dictionary, add to stack
            if (root.left != null && !nodeEdges.ContainsKey(root.left))
                stack.Push(root.left);                            
            else if (root.right != null && !nodeEdges.ContainsKey(root.right))
                stack.Push(root.right);                            
            else {  // if child nodes null or both already in dict, pop off latest,
                // get edge value of children, add current nodes edge value to dict, check diameter
                root = stack.Pop();
                var left = 0;
                var right = 0;
                if (root.left != null && nodeEdges.ContainsKey(root.left)) left = nodeEdges[root.left];
                if (root.right != null && nodeEdges.ContainsKey(root.right)) right = nodeEdges[root.right];
                nodeEdges[root] = left > right ? left + 1 : right + 1;
                diameter = left + right > diameter ? left + right : diameter;
            }
        }
        return diameter;
    }

    private int Recursive(TreeNode root, ref int diameter) {
        if (root == null) return 0;
        (var left, var right) = 
            (Recursive(root.left, ref diameter), Recursive(root.right, ref diameter));
        diameter = left + right > diameter ? left + right : diameter;
        return left > right ? left + 1 : right + 1;
    }
}