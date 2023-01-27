# Balanced Binary Tree
## Easy
### https://leetcode.com/problems/balanced-binary-tree/
#### O(n)

Iterative:  
* DFS, use a stack LIFO, search left first
* Use a map to record depth values for each node
* If L/R nodes don't exist, or already added to map:
* Get child node depth values from map, if doesn't exist - use 0
* If the difference between children depth values is greater than 1, not balanced tree - return false
* Else add current node to map - using the largest child depth value + 1 (nodes have inherent depth value of one)

Recursive:  
* DFS, use tuple return value (bool, int) for (if balanced, subtree depth)
* If node null, (true, 0)
* Else, explore left and right nodes
* If either child node not balanced, return false
* If difference between L/R subtree depths is greater than 1 - not balanced, return false
* Else, return (balanced, Max(left depth, right depth) + 1)
