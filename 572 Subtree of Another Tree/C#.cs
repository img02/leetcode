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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        return Iterative(root, subRoot);
        //return Recursive(root, subRoot);
    }

    // go through the nodes using stack - DFS
    // if you hit a node matching the value of subroot, call second function, if true - is subtree
	// else repeat for remaining nodes
    private bool Iterative(TreeNode root, TreeNode subroot) {           
        var stack = new Stack<TreeNode>();

        while (root != null || stack.Count > 0) {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
            root = stack.Pop();            
            if (root.val == subroot.val && IterativeSubTree(root, subroot)) return true;
            root = root.right;        
        }
        return false;
    }

    // if matching root value found, call this function
    // use 2 stacks, add nodes using DFS, at beginning of loop, check if stack counts match
    // add all left nodes til null, pop off both stack, compare values
    // try going to right node, repeat until either matching subtree or false
    private bool IterativeSubTree(TreeNode root, TreeNode subroot) {
        var rootStack = new Stack<TreeNode>();
        var subStack= new Stack<TreeNode>();
        rootStack.Push(root);
        subStack.Push(subroot);

        while (rootStack.Count > 0 || subStack.Count > 0) {            
            if (rootStack.Count != subStack.Count) return false;
            while (root != null || subroot != null) {
                if (root != null) 
                {
                    rootStack.Push(root);
                    root = root.left;
                }
                if (subroot != null) 
                {
                    subStack.Push(subroot);
                    subroot = subroot.left;
                }
            }
            root = rootStack.Pop();
            subroot = subStack.Pop();
            if (root.val != subroot.val) return false;
            root = root.right;
            subroot = subroot.right;
        }
        return true;
    }

    // if both nodes null, matching
    // if only one node null, not matching
    // if matching node values found, call second function, repeat    
    private bool Recursive(TreeNode root, TreeNode subRoot) {
        // if both false checked first
        if (root == null && subRoot == null) return true;
        // if either/both false checked second, so won't conflict
        if (root == null || subRoot == null) return false;   
        var isSubTree = false;
        if (root.val == subRoot.val) isSubTree =  RecursiveIsSubTree(root, subRoot);
        //if RecursiveIsSubTree is false, try the rest of the nodes since not bst, can have dupes 
        if (isSubTree) return true; 
        return Recursive(root.left, subRoot) || Recursive(root.right, subRoot);
        
    }
    // if both null, match, else not match
    // if both values don't match, false
    // else matching values, repeat for all available nodes
    private bool RecursiveIsSubTree(TreeNode root, TreeNode subRoot) {
        if (root == null && subRoot == null) return true;
        if (root == null || subRoot == null) return false;   
        if (root.val != subRoot.val) return false;
        return RecursiveIsSubTree(root.left, subRoot.left) && RecursiveIsSubTree(root.right, subRoot.right);
    }
}