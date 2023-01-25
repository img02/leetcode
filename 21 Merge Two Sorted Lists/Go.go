/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
func mergeTwoLists(list1 *ListNode, list2 *ListNode) *ListNode {
    
    mergedList := &ListNode{}
    head := mergedList
    recursive(list1, list2, mergedList)
    return head.Next        
    //return iterative(list1, list2)
}

func recursive(list1 *ListNode, list2 *ListNode, mergedList *ListNode) {
    if list1 == nil && list2 == nil {
        return
    }

    if list1 == nil {
        mergedList.Next = list2
        return
    }
    if list2 == nil {
        mergedList.Next = list1
        return
    }

    if list1.Val <= list2.Val {
        mergedList.Next = list1
        mergedList = mergedList.Next
        list1 = list1.Next
    } else {
        mergedList.Next = list2
        mergedList = mergedList.Next
        list2 = list2.Next
    }
    recursive(list1, list2, mergedList)
}


func iterative(list1 *ListNode, list2 *ListNode) *ListNode {
     if list1 == nil && list2 == nil {
         return nil
    }

    // create *listnode that contains empty listnode
    var merged *ListNode  = &ListNode{}
    head := merged

    // while at least one of the lists still has nodes
    for list1 != nil && list2 != nil {

        if list1.Val <= list2.Val {
            //append next node, set merged to next node, mode list1 to its next node
            merged.Next = list1
            merged = merged.Next
            list1 = list1.Next
        } else {
            merged.Next = list2
            merged = merged.Next
            list2 = list2.Next
        }
    }

    // once at least one of the lists is nil
    // just add the remaining list
    // since these are sorted lists
    if list1 != nil {
        merged.Next = list1
    } 
    if list2 != nil {
        merged.Next = list2
    }

    // called head, but actually the empty node created earlier
    // it's Next is the real head of the new merged list
    return head.Next
}