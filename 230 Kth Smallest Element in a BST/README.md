# Kth Smallest Element in a BST
## Medium
### https://leetcode.com/problems/kth-smallest-element-in-a-bst

Go down all the way left, 


Iterative:  
```
	1. Using a LIFO data structure / system  
	2. Once all the way down left (left node null)  
	3. Pop the last node off the Stack  
	4. Decrement K  
	5. If K is 0; We've found our Kth Node -- return the value 
```
	
	
Recursive:  
```
	1. Pass in Node, K, and KthValue (set to -1) // since Node Value is 0 <= Node.val <= 10^4  
	2. Go down left node  
	3. If KthValue is not -1 -- Kth Smallest Value has been found from and we're returning; popping off call stack  
	4. Decrement K  
	5. If K is 0; Kth Node -- return value up  
	6. Go down right node  
	7. Go back up, returning current K index count  
```
