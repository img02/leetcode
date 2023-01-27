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
    public bool IsBalanced(TreeNode root) {
        return Iterative(root);
        /*
        var (balanced, _ ) = Recursive(root);       
        return balanced;
        */
    }
    
    private bool Iterative(TreeNode root) {
        if (root == null) return true;

        var depths = new Dictionary<TreeNode, int>();
        var toDo = new Stack<TreeNode>();
        toDo.Push(root);

        while (toDo.Count > 0)
        { 
            root = toDo.Peek();
            if (root.left != null && !depths.ContainsKey(root.left)) 
                toDo.Push(root.left);                
            else if (root.right != null && !depths.ContainsKey(root.right))
                toDo.Push(root.right);
            else
            {   // since we are doing DFS, by the time we get here, any child nodes will be in map
                var left = root.left != null ? depths[root.left] : 0;
                var right = root.right != null ? depths[root.right] : 0;
                // if depth difference on subtrees greater than 1, not balanced
                if (Math.Abs(left - right) > 1) return false; 
                var depth = left >= right ? left + 1 : right + 1;                
                depths[root] = depth;
                 toDo.Pop();
            }
        }
        return true;
    }

    private (bool balanced, int depth) Recursive(TreeNode root) {
        if (root == null) return (true, 0);

        var (lBalanced, left) = Recursive(root.left);
        var (rBalanced, right) = Recursive(root.right);

        if (!lBalanced || !rBalanced) return (false,0);
        if (Math.Abs(left - right) > 1) return (false,0);
        return left >= right ? (true, left + 1) : (true, right + 1);
    }
}