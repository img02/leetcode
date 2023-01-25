/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func invertTree(root *TreeNode) *TreeNode {
    //return iterative(root)
    return recursive(root)
}

func iterative(root *TreeNode) *TreeNode {
    stack := make([]*TreeNode, 0)
    head := root

    for root != nil || len(stack) != 0 {

        // go down left as much as possible
        for root != nil {
            stack = append(stack, root)
            root = root.Left
        }

        // pop off stack
        popIndex := len(stack)-1;
        root = stack[popIndex]
        stack = stack[:popIndex]

        //swap left and right        
        temp := root.Left
        root.Left = root.Right
        root.Right = temp
        // could use one liner:
        // root.Left, root.Right = root.Right, root.Left

        //then go down left (what was originally right node)
        root = root.Left
    }

    return head
}

func recursive(root *TreeNode) *TreeNode {
    if root == nil {
        return nil
    }
    
    temp := root.Left
    root.Left = root.Right
    root.Right = temp

    recursive(root.Left)
    recursive(root.Right)
    
    // or one liner, but a bit harder to read / understand
    // root.Left, root.Right = recursive(root.Right), recursive(root.Left) 
    return root
}