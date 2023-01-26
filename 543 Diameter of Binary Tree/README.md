# Diameter of Binary Tree
## Easy
### https://leetcode.com/problems/diameter-of-binary-tree
#### O(n)


Recursive:  
* pass pointer for diameter int
* Go down left nodes
* Go down right node
* Compare left + right > diameter, and update diameter if needed
* Return edge value as the greatest of either child nodes edge count + 1 (add 1 for default edge value, as a child node will have at least 1 edge, to parent)
* Repeat for all nodes

Iterative:  
* Use Stack, add first node to stack
* Use Map, TreeNode as key, int 'Edge Value' as value
* While Stack is not empty
* Peek last node
* If left node exists and not in map as Key, add to map, continue
* Else if right node exists and not in map, add to map, continue
* If both exist in map or node(s) don't exist, pop node
* Get edge value of Left and Right child nodes, (default to 0 if key not in map)
* Add current node to map, set edge value as Max(left, right) + 1 (plus 1, since node has innate edge value of 1 to parent)
* Check if diameter of current node (left + right) > diameter ? update diameter : diameter
* Repeat (next node on stack will be parent of curr node, then logic should try adding right node, left already in map, calc new values, etc.)
