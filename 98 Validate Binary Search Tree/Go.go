/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func isValidBST(root *TreeNode) bool {    

    return iterative(root)
    //return recursive(root, math.MaxInt, math.MinInt)   
}

func iterative(root *TreeNode) bool {
    stack := make([]*TreeNode,0)
    var prevNode *TreeNode

    for root != nil || len(stack) != 0{
        for root != nil{
            stack = append(stack, root)
            root = root.Left
        }

        popIndex := len(stack)-1
        root = stack[popIndex]
        stack = stack[:popIndex]

        if prevNode != nil && root.Val <= prevNode.Val{
            return false
        }

        prevNode = root
        root = root.Right
    }
    return true
}

// apparently int could be 32 or 64 bits depending on architecture
// so might need int64 in some cases?
func recursive(root *TreeNode, max int, min int) bool {
    if root == nil{
        return true
    }

    if root.Val <= min || root.Val >= max{
        return false
    }

    return recursive(root.Left, root.Val, min) &&
    recursive(root.Right, max, root.Val)
}