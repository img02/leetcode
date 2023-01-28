/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func isSubtree(root *TreeNode, subRoot *TreeNode) bool {
    //return iterative(root, subRoot)
    //return recursiveString(root, subRoot)
    return recursive(root, subRoot)
}

//slow
func iterative(root *TreeNode, subRoot *TreeNode) bool {
    // try using queue
    q := []*TreeNode{root}

    for len(q) > 0 {
        //dequeue
        root = q[0]
        q = q[1:]

        if root == nil {
            continue
        }
        q = append(q, root.Left)
        q = append(q, root.Right)

        if root.Val == subRoot.Val && iterativeSubTreeCheck(root, subRoot) {
            return true
        }
    }
    return false
}

func iterativeSubTreeCheck(root *TreeNode, subRoot *TreeNode) bool {
    qRoot := []*TreeNode{root}
    qSub := []*TreeNode{subRoot}

    for len(qRoot) > 0 || len(qSub) > 0 {    
        //dequeue
        root, subRoot = qRoot[0], qSub[0]
        qRoot, qSub = qRoot[1:], qSub[1:]

        if len(qRoot) != len(qSub) {
            return false
        }
        if root == nil && subRoot == nil {
            continue
        }
        if root == nil || subRoot == nil {
            return false
        }
        if root.Val != subRoot.Val {
            return false
        }
        qRoot, qSub = append(qRoot, root.Left), append(qSub, subRoot.Left)
        qRoot, qSub = append(qRoot, root.Right), append(qSub, subRoot.Right)
    }
    return true;

}

func recursive(root *TreeNode, subRoot *TreeNode) bool {
    if root == nil {
        return false
    }
    if root.Val == subRoot.Val && recursiveSubTreeCheck(root, subRoot) {
        return true;
    }
    return recursive(root.Left, subRoot) || recursive(root.Right, subRoot)
}

func recursiveSubTreeCheck(root *TreeNode, subRoot *TreeNode) bool {
    if root == nil && subRoot == nil {
        return true
    }
    // above check catches if both nil, below if either or 
    if root == nil || subRoot == nil {
        return false
    }
    if root.Val != subRoot.Val {
        return false
    }
    return recursiveSubTreeCheck(root.Left, subRoot.Left) && recursiveSubTreeCheck(root.Right, subRoot.Right)
}


//slower than normal recursive
//faster than iterative
//more mem than normal recursive
//less mem than iterative
func recursiveString(root *TreeNode, subRoot *TreeNode) bool {
    tree := serializeTree(root)
    subTree := serializeTree(subRoot)
    return strings.Contains(tree, subTree)
}

func serializeTree(node *TreeNode) string {
    if node == nil {
        return "#"
    }    
    left := serializeTree(node.Left)    
    right := serializeTree(node.Right)

    //separate everything with spaces, to cater for double digit values    
    return fmt.Sprintf(" %v %v %v ", node.Val, left, right)
}