/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func kthSmallest(root *TreeNode, k int) int {
    return iterative(root, k)
    //_, kth := recursive(root, k, -1)
    //return kth
}

func iterative(root *TreeNode, k int) int {
    //use slice for 'last in first out' 
    stack := make([]*TreeNode, 0)

    for root != nil || len(stack) != 0 {
        //go all the down the left
        for root != nil {
            stack = append(stack, root)
            root = root.Left
        }
        
        //pop off the last node
        popIndex := len(stack)-1
        root = stack[popIndex]
        stack = stack[:popIndex]

        //decrement k until 0, return value
        k--
        if k == 0 {
            return root.Val
        }
        //else try going down right and repeat
        root = root.Right
    }
    return 0
}

func recursive(root *TreeNode, k int, kth int) ( kIndex int,  kthValue int ){
    // if root null, return current kindex and kth (should still be -1)
    if root == nil {
        return k, kth
    }

    // go down all the way left first
    k, kth = recursive(root.Left, k, kth)

    // if kth value changed, return answer
    if kth != -1 {
        return 0, kth
    }
    // decrement k, if k is 0, we've met our kth smallest node
    k--
    if k == 0 {
        return k, root.Val
    }
    // otherwise go down right node, repeat
    k, kth = recursive(root.Right, k, kth)

    return k, kth
}