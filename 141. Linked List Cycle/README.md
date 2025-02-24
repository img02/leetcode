# 141. Linked List Cycle
## Easy
### https://leetcode.com/problems/linked-list-cycle/description/
#### O(n)


based on constraints of the range of the number of nodes
	-	could just have an index and while (head.next != null) increase index until max constraint hit
	-	constant time memo

hashset
	- loop thru node, 
		-	is set contains node -> return true
		-	if hit null -> exit loop -> return false
	- add node to hashset	
	
tortoise and hare - fast slow pointer
	- one pointer goes to next
	- two pointer goes to next.next
	- since two jumps twice
		-	need to check if two != null && two.next != null
		-	(if two.next isn't null,
			-	two = two.next.next, 
			-	so on next loop we need to check that next.next wasn't null)
			
			