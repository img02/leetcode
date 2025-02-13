# Reverse Linked List II
## Medium
### https://leetcode.com/problems/reverse-linked-list-ii/description/
#### O(n)


break the linked list down into 3 parts
-	the left side (save a pointer to the 'tail')
-	the middle (sublist that gets reversed)
-	right side (the reversed sublist tail (og head) must point to)

create a dummy node that points to the og head

let leftTail = dummy
let index = 1;

loop through until left-1 while updating the leftTail

loop through until right+1 while reversing list

leftTail should point to the node before left index,  
-	leftTail.next = original 'head' of the sublist to reverse
	- point that 'head', now 'tail', to the 'head' of the right list
		- leftTail.next.next = curr
-	point leftTail.next to the new 'head' of the reversed list
	-	leftTail.next = prev;

return dummy.next
	- originally pointed the the head
	- in the event that the list only contains 2 nodes
		-	leftTail still points to dummy
		-	so when leftTail.next was set in previous step, dummy.next now points to new head.
		-	trust me, draw it in paint
