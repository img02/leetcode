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
    public TreeNode InvertTree(TreeNode root) {      
      return Iterative(root);
      //return Recursive(root);
    }

    private TreeNode Iterative(TreeNode root) {
        var stack = new Stack<TreeNode>();
        var head = root;
        while (root != null || stack.Count != 0)
        { // go down all the way left
            while (root != null)
            {
                stack.Push(root);
                root = root.left;               
            }
            //pop off, swap left and right
            root = stack.Pop();
            (root.left, root.right) = (root.right, root.left);
            root = root.left; // originally right node
        }
        return head;
    }

    private TreeNode Recursive(TreeNode root) {
          if (root == null) return null;
          (root.left, root.right) = (root.right, root.left);
          InvertTree(root.left);
          InvertTree(root.right);
          return root;
    }
}