/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func diameterOfBinaryTree(root *TreeNode) int {
    return iterative(root)

    /*
    diameter := 0
    recursive1(root, &diameter)
    return diameter
    */
}

func iterative(root *TreeNode) int {
    if root == nil {
        return 0
    }
    diameter := 0
    stack := make([]*TreeNode, 0)
    //map for max edge value of each node
    nodeMap := make(map[*TreeNode]int)

    stack = append(stack, root)

    for len(stack) != 0 {
        peekIndex := len(stack)-1
        root = stack[peekIndex]

        if _, keyExists := nodeMap[root.Left]; root.Left != nil && !keyExists{
            stack = append(stack, root.Left)
        } else if _, keyExists := nodeMap[root.Right]; root.Right != nil && !keyExists {
            stack = append(stack, root.Right)
        } else {
            root = stack[peekIndex]
            stack = stack[:peekIndex] //pop off
            left := nodeMap[root.Left] 
            right := nodeMap[root.Right] 
            // add the max value of this node
            // we add 1, since this node itself will have an edge to parent
            if (left >= right) {
                nodeMap[root] = left + 1
            } else {
                nodeMap[root] = right + 1
            }
            // check if current node's diameter is greater than current largest diameter
            if left + right > diameter {
                diameter = left + right
            }
        }
    }             
    return diameter
}



// DFS - go down left, as you go back up, increase edge count by 1
// returning the edge count of whichever subtree is largest
// if left + right subtree edge count is greater than current diameter
// update diameter - pointer to int
func recursive1(root *TreeNode, diameter *int) int {
    if root == nil {
        return 0
    }

    left := recursive1(root.Left, diameter)
    right := recursive1(root.Right, diameter)

    // if the diameter of this node + its subtrees
    // is greater than current largest diameter, replace
    if left + right > *diameter {
        *diameter = left + right
    }

    // since we are going back up to parent node,
    // increase the edge count by 1
    // (edge of child to parent)
    // compare left and right subtrees, return largest edge count
    if left >= right {
        return left + 1
    }
    return right + 1
}



//=================================================
// first attempt
func recursive(root *TreeNode, diameter int) int {
    if root == nil {
        return diameter
    }

    left := recursiveChildren(root.Left, 1)
    right := recursiveChildren(root.Right, 1)
    
    if (left + right > diameter) {
        diameter = left + right
    }

    leftDiameter := recursive(root.Left, diameter)
    if leftDiameter > diameter {
        diameter = leftDiameter
    }

    rightDiameter := recursive(root.Right, diameter)
    if rightDiameter > diameter {
        diameter = rightDiameter
    }
    
    return diameter    
}

//gets the longest edge count subtrees
func recursiveChildren(root *TreeNode, edges int) int {
        if root == nil {
        return edges-1
    }

    left := recursiveChildren(root.Left, edges + 1)
    right := recursiveChildren(root.Right, edges + 1)
    //left, right := recursiveChildren(root.Left, edges + 1), recursiveChildren(root.Right, edges + 1)

    if left >= right {
        return left
    }

     return right
}