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
    public IList<int> InorderTraversal(TreeNode root) 
    {
     return Iterative(root);
     //return Recursive(root);   
    }

// iterative using stack
    private IList<int> Iterative(TreeNode root){
        var values = new List<int>();
        var stack = new Stack<TreeNode>();

        while (root != null || stack.Count != 0)
        {          
            // go all the way down left
            // add current node to stack, traverse left, check if null
            while(root != null){
                stack.Push(root);
                root = root.left;
            }       

            //once left is null, go up one and add the value
            root = stack.Pop();
            values.Add(root.val);

            //now try going down right and repeat
            root = root.right;
        }
        return values;
    }


// recursive solution
    private IList<int> Recursive(TreeNode root)
    {
        var values = new List<int>();       
        RecursiveTravel(root, values);
        return values;
    }

    private void RecursiveTravel(TreeNode root, IList<int> values)
    {
        if (root == null) return;
        RecursiveTravel(root.left, values);
        values.Add(root.val);
        RecursiveTravel(root.right, values);
    }
}