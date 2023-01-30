/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val   int
 *     Left  *TreeNode
 *     Right *TreeNode
 * }
 */

func lowestCommonAncestor(root, p, q *TreeNode) *TreeNode {
	//recursive(root, p, q)
    //return answer
    //return recursive1(root, p , q)
    return iterative(root, p , q)
}

func iterative(root, p, q *TreeNode) *TreeNode {

    for {
        if root.Val > p.Val && root.Val > q.Val {
            root = root.Left
        } else if root.Val < p.Val && root.Val < q.Val {
            root = root.Right
        } else {
            return root
        }
    }
}

// nodes [2, 10^5] 
// p and q must exist, can't be nil
// since in a bst, left child is smaller,
// right child is larger than current node
// to find LCA, if current node val > both
// go down left node
// if node val < both, go down right node
// if it is neither smaller nor larger than BOTH p && q values
// it will be the LCA
func recursive1(root, p, q *TreeNode) *TreeNode {
    if root.Val > p.Val && root.Val > q.Val {
        return recursive1(root.Left, p, q)
    }
    if root.Val < p.Val && root.Val < q.Val {
        return recursive1(root.Right, p, q)
    }
    return root
}


//attempt 1
var answer *TreeNode

func recursive(root, p, q *TreeNode) bool {
    if root == nil {
        return false
    }
    left, right := recursive(root.Left, p, q), recursive(root.Right, p, q)
    // if p or q val matches, and a child node matches,
    // this node is the common ancestor (+ of itself)
    if (root.Val == p.Val || root.Val == q.Val) && (left || right) {        
        answer = root
        // else if this node matches, and child nodes don't, return true        
    } else if root.Val == p.Val || root.Val == q.Val {
        return true
        // else if both child nodes are matching values, this node is LCA
    } else if left && right {
        answer = root        
        // else if only one child node matches, return true
    } else if left || right {
        return true
    }
    return false
}