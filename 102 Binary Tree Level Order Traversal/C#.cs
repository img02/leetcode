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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        return Iterative(root);
    }

    private IList<IList<int>> Iterative(TreeNode root) {        
        var values = new List<IList<int>>();
        var depthValues = new List<int>();
        var set = new HashSet<TreeNode>();
        var q = new Queue<TreeNode>();
        var depthNodeCount = 0;
        var childDepthCount = 0;

        if (root == null) return values;
        set.Add(root);
        q.Enqueue(root);
        depthNodeCount++;

        while (q.Count > 0) {            
            root = q.Dequeue();           
            depthValues.Add(root.val);
            depthNodeCount--;
            // if not null and not already added
            if (root.left != null && set.Add(root.left)) {
                q.Enqueue(root.left);
                childDepthCount++;
            }
            if (root.right != null && set.Add(root.right)) {
                q.Enqueue(root.right);
                childDepthCount++;
            }
            // once depthNodeCount == 0, current depth nodes adde to list
            // reset list, set depth count as child depth count, repeat with child nodes
            if (depthNodeCount == 0) {
                values.Add(depthValues);
                depthValues = new List<int>();  
                depthNodeCount = childDepthCount;    
                childDepthCount = 0;                          
            }
        }
        return values;
    }
}