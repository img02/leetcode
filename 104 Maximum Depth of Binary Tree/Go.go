/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func maxDepth(root *TreeNode) int {
    return iterative(root)

    /*
    return recursive(root, 0)
    */
}

func iterative(root *TreeNode) int {
    //BFS
    //queue   
    q := make([]*TreeNode,0)
    depth := 0

    if root == nil {
        return 0
    }

    // queue first node, set count of nodes in current depth to 1
    q = append(q, root);        

    // while queue not empty, add all children nodes
    // increase depth count
    // dequeue parents 
    // set count of nodes in current depth
    // repeat
    for len(q) != 0 {
        depth++
        // 1 at first, then amount of newly added children nodes after 
        // parents dequeued
        depthNodeCount := len(q) 
        for ; depthNodeCount > 0; depthNodeCount-- {
            // dequeue
            root = q[0]
            q = q[1:]

            if root.Left != nil {
                q = append(q, root.Left)
            }
            if root.Right != nil {
                q = append(q, root.Right)          
            }          
        }    
    }            
    return depth
}

//DFS
func recursive(root *TreeNode, depth int) int {
    if root == nil {
        return depth
    }

    leftDepth := recursive(root.Left, depth+1)
    rightDepth := recursive(root.Right, depth+1)

    if leftDepth > rightDepth {
        return leftDepth
    } else {
        return rightDepth
    }
}