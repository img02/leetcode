/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func inorderTraversal(root *TreeNode) []int {
        return iterative(root)
        //return recursive(root)
}

func iterative(root *TreeNode) []int {
    values := make([]int, 0)
    //using slice for 'last in first out'
    stack := make([]*TreeNode, 0);

    for root != nil || len(stack) != 0{
        //traverse down as far left as possible, adding to the stack
        for root != nil {
            stack = append(stack, root)
            root = root.Left
        }
        
        // 'pop' the last in node
        popIndex := len(stack)-1
        root = stack[popIndex]
        stack = stack[:popIndex]
        
        //add it's value and try going down right, repeat
        values = append(values, root.Val)

        root = root.Right
    }
    return values
}


func recursive(root *TreeNode) []int {
    if root == nil {
        return []int{}
    }

    values := make([]int,0)    
    values = append(values, recursive(root.Left)...)
    values = append(values, root.Val)
    values = append(values, recursive(root.Right)...)
    return values;
}