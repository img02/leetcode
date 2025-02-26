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
        //return Iterative(list1, list2);
        return Recursive(list1, list2, new ListNode());
    }

    public ListNode Recursive(ListNode list1, ListNode list2, ListNode merged){
       
         if(list1 != null && (list2 == null || list1.val <= list2.val)){
            merged.next = list1;
            Recursive(list1.next, list2, merged.next);
        }
        else if (list2 != null){
            merged.next = list2;
            Recursive(list1, list2.next, merged.next);
        }
        return merged.next;
    }

    public ListNode Iterative(ListNode list1, ListNode list2){

        var dummy = new ListNode(0,null);
        var merged = dummy;

        while(list1 != null && list2 != null){

            if(list1.val <= list2.val){
                merged.next = list1;
                list1 = list1.next;
            }
            else {
                merged.next = list2;
                list2 = list2.next;
            }
            merged = merged.next;
           

        }

        if(list1 == null) merged.next = list2;
        else merged.next = list1;

        return dummy.next;
    }
}