/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
func reverseList(head *ListNode) *ListNode {

	//return reverseListIterative(head)
	return reverseListRecursive(head, nil)
}

func reverseListRecursive(head *ListNode, prev *ListNode) *ListNode {
	// if head (which is 'next' node in list) is nil,
	// return prev (head of reversed list)
	if head == nil {
		return prev
	}

	// point next to next node
	next := head.Next

	// point current node's 'Next' to previous node
	// and prev to current
	head.Next = prev
	prev = head
	//recursively repeat with the next node in the list
	return reverseListRecursive(next, prev)
}

func reverseListIterative(head *ListNode) *ListNode {
	var prev *ListNode
	for head != nil {
		// store pointer to next node
		next := head.Next

		// point head.Next to previous node, point previous to current node
		head.Next = prev
		prev = head
		head = next
	}
	return prev
}