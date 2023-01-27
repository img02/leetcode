/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func isSameTree(p *TreeNode, q *TreeNode) bool {
    //return iterative2(p, q)
    return iterative1(p, q)
    //return recursive(p, q)
}

type nodes struct {
    p *TreeNode
    q *TreeNode
}
func iterative2(p *TreeNode, q *TreeNode) bool {
    stack := []nodes{{p,q}}

    for len(stack) > 0 {
        //pop
        popIndex := len(stack) - 1
        p, q = stack[popIndex].p, stack[popIndex].q
        stack = stack[:popIndex]

        p_nil := p == nil
        q_nil := q == nil

        if q_nil && p_nil {
            continue
        }
        if q_nil && !p_nil || !q_nil && p_nil {
            return false
        }
        if q.Val != p.Val {
            return false
        }

        left := nodes{p.Left, q.Left}
        right := nodes{p.Right, q.Right}
        
        stack = append(stack, left, right)
    }
    return true
}

// attempt 1 idk
func iterative1(p *TreeNode, q *TreeNode) bool {
    // One stack for each tree, or could use struct for both in one.
    pStack := []*TreeNode{p}
    qStack := []*TreeNode{q}

    for len(pStack) > 0 && len(qStack) > 0 {
        if len(pStack) != len(qStack) {
            return false
        }

        //pop
        popIndex := len(pStack) - 1
        p, q = pStack[popIndex], qStack[popIndex]
        pStack, qStack = pStack[:popIndex], qStack[:popIndex]        

        //if both null, all good
        if q == nil && p == nil {
            continue
        }
        //if only one nil, not same tree
        if (q == nil && p != nil) || (p == nil && q != nil) {
            return false
        }
        if (p.Val != q.Val) {
            return false
        }
        
        // just add all children nodes, even if nil -- add in same order - Left > Right or Right > Left
        // we check if one or both are nil above
        pStack = append(pStack, p.Left, p.Right)        
        qStack = append(qStack, q.Left, q.Right)
    }
    return true
}

//DFS
func recursive(p *TreeNode, q *TreeNode) bool {
    // if both null, all good
    if q == nil && p == nil {
        return true
    }
    // if only one null, not same tree
    if (q == nil && p != nil) || (p == nil && q != nil){
        return false
    }
    
    if (q.Val != p.Val) {
        return false
    }

     return recursive(p.Left, q.Left) && recursive(p.Right, q.Right)
}