# Validate Binary Search Tree
## Medium
### https://leetcode.com/problems/validate-binary-search-tree/description/

```
-2^31 <= Node.val <= 2^31 - 1

```

In a BST:
```  
	each left subtree is smaller in value that its parent 
	each right subtree is larger than its parent
		each left subtree of a right subtree is larger than that right subtree's parent
```


Recursive:  
```
	Go down left, each left node must be smaller than its parent node (max)
	
	Go down right, each right node must be larger than its parent node (min)

	so pass through (node, max, min)
	with max, min initially set to int64 max and min values - as node value range is int32 max/min	

	When going down left, pass the current node value as the max value
	When going down right, pass the current node value as the min value

	each node value must then be greater than min, smaller than max.
```

Iterative:
```
	Using a stack, add every left node

	Pop off and compare node value to 'previous node' (prevNode) - initially null

	Since we are going down all the way left first, the first prevNode value must be the smallest in the BST

	We then try going down the right node and add any nodes to stack.

	As the prevNode is the smallest value in the BST, 
	the next node popped off must be either the parent node 
	or part of the right subtree of the parent node

	Both of which must be greater that prevNode value.

	As we go down a right subtree, the prevNode (last node popped off stack)
	should always be the parent node of the subtree, therefore smaller than any of the subtree values

	The next node on the stack to be popped, if existing, must be
	left subtree node > parent node > right subtree node:
		left node is always smaller than parent
		parent always smaller than right node
		right node larger than parent and parent's left node / subtree
	
```
paint attempt at visual explanation
![image](https://user-images.githubusercontent.com/70348218/213951834-89838a19-2f19-430f-9c72-b3ed7173f7b6.png)

	
