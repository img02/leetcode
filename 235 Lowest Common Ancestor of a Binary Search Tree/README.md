# Lowest Common Ancestor of a Binary Search Tree
## Medium
### https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
#### O(n)


```
Constraints:

    The number of nodes in the tree is in the range [2, 10^5].
    -10^9 <= Node.val <= 10^9
    All Node.val are unique.
    p != q
    p and q will exist in the BST.

```

BST 
- left child is less than root, right child is greater than root
- if current node value is greater than both p and q values, go down left node
- if current node value is less than both p and q values, go down right node
- if current node value is equal to or between both p and q values, it is LCA
