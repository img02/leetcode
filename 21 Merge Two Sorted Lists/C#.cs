/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {       
       var mergedList = new ListNode();
       var head = mergedList;
       Recursive(list1, list2, mergedList);
       return head.next;
       //return Iterative(list1, list2);
    }

    private void Recursive(ListNode list1, ListNode list2, ListNode mergedList) {
        if (list1 == null && list2 == null) return;
        if (list1 == null){
            mergedList.next = list2;
            return;
        }
        if (list2 == null){
            mergedList.next = list1;
            return;
        }

        if (list1.val <= list2.val)
        {
            mergedList.next = list1;
            mergedList = mergedList.next;
            list1 = list1.next;
        } 
        else
        {
            mergedList.next = list2;
            mergedList = mergedList.next;
            list2 = list2.next;
        }
        Recursive(list1, list2, mergedList);
    }

    private ListNode Iterative(ListNode list1, ListNode list2) {
         if (list1 == null && list2 == null) return null;        
        var head = new ListNode();             
        var curr = head;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                curr.next = list1;
                curr = curr.next;
                list1 = list1.next;
            } 
            else
            {
                curr.next = list2;
                curr = curr.next;
                list2 = list2.next;
            }
        }
        if (list1 == null) curr.next = list2;
        if (list2 == null) curr.next = list1;        
        return head.next;
    }
}