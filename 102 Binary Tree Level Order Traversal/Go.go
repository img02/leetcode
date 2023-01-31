/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func levelOrder(root *TreeNode) [][]int {
    return recursive(root)
}

func recursive(root *TreeNode) [][]int {
    ans := make([][]int,0)    
    // 'queue' - actually used like a list but...
    q := make([]*TreeNode,0)

    if root == nil {
        return ans
    }
    q = append(q, root)

    for len(q) > 0 {
        dVal := make([]int,0)
        // list for all child nodes of the nodes currently in list
        // represents the nodes in the next depth level
        childQ := make([]*TreeNode, 0)

        // iterate through current queue (which represents a depth level)
        // and add all values, while adding children to childQ
        for i := range q {
            //peek
            // -- 'dequeue' if using real queue
            // but since this is go and I am using slices, it doesn't matter
            root = q[i]

            // add value to depth value array 
            dVal = append(dVal, root.Val)

            // add all children
            if root.Left != nil {
                childQ = append(childQ, root.Left)
            }       
            if root.Right != nil {
                childQ = append(childQ, root.Right)
            }
        }
        // append array of current depth values to answer
        // and set child queue as current queue
        ans = append(ans, dVal)
        q = childQ
    }
    return ans    
}