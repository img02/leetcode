# Remove Nth Node From End of List
## Medium
### https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/
#### O(n)


use dummy node to point to head  

use two pointers, left at dummy, right at head  

move right while n > 0, decrement n  

the move right and left while right isn't null  

finally skip a node, left.next = left.next.next  

![image](https://github.com/user-attachments/assets/619e7679-2dfe-4272-b3f3-799bf4b8cf99)
