/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func isBalanced(root *TreeNode) bool {
    return iterative(root)
    /*
    balanced, _ := recursive(root)    
    return balanced
    */
}

func iterative(root *TreeNode) bool {
    if (root == nil) {
        return true
    }
    toDo := []*TreeNode {root}
    depths := make(map[*TreeNode]int)

    for len(toDo) > 0 {
        // peek, dont' pop yet
        popIndex := len(toDo)-1
        root = toDo[popIndex]
        
        if _, ok := depths[root.Left]; root.Left != nil && !ok {
            toDo = append(toDo, root.Left)
        } else if _, ok := depths[root.Right]; root.Right != nil && !ok {
            toDo = append(toDo, root.Right)
        } else {
            // if key doesn't exist, set zero-value int - 0
            left := depths[root.Left]
            right := depths[root.Right]

            // if depth difference of l/r subtrees bigger than 1, not balanced
            if left - right > 1 || left - right < -1 {
                return false
            }
            depth := left
            if right > left {
                depth = right
            }            
            depths[root] = depth + 1
            // pop last node off stack
            toDo = toDo[:popIndex]
        }
    }
    return true    
}

func recursive(root *TreeNode) (balanced bool, depth int) {
    if root == nil {
         return true, 0
    }

    lBal, left := recursive(root.Left)
    rBal, right := recursive(root.Right)

    if !lBal || !rBal {
         return false, 0
    }

    if left - right > 1 || left - right < -1 {
        return false, 0
    }

    if left >= right {
        return true, left + 1
    }
    
    return true, right + 1
}