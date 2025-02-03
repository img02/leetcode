# Lowest Common Ancestor of a Binary Tree
## Medium
### https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/description/
#### O(n)


There are 2 possible cases,

**1:**  

![image](https://github.com/user-attachments/assets/b37ee7f8-e24b-4857-81ee-065485f8070f)

The LCA is a parent,
  that is to say that nodes **p** and **q** are in the left and right branches.



**2:**  

![image](https://github.com/user-attachments/assets/43399fca-5fb8-41dd-affa-c19d1739cf99)

The LCA is one of the nodes, **p** or **q**,
  that is to say that one of the nodes is a descendant of the other.  

\
\
\
\
\
So by using DFS and going down each node, left then right, returning either the node **p** / **q** or null - we end up with one of three possibilities:

Either both left and right branches contain **p** and **q**, in which case the current node is the LCA - return it upwards.

OR

One branch contains **p** / **q** and the other is null, in which case we return the relevant node.
-- We don't need to check if the other value is a descendant of this node. If it is, then once we return to the root node it will have the result of **value + null**, showing that **value** node is the LCA.

OR

Both are null, so just return null (or any of the null nodes).

Eventually the LCA node will be propogated up through the recursive function calls.


E.G:

![image](https://github.com/user-attachments/assets/41402a5b-b11d-47fa-9642-8f4786821a49)

Nodes return values based on their left + right branch return values.

Nodes with  null + null will return null upwards.
Nodes with value + null will return the node with value. 
Nodes with value + value will return itself. -- if both branches contain **p** and **q** then this node must be the LCA.
