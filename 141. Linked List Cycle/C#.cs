/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        return WithTwoPointers(head);
        //return WithSet(head);
        //return FixedLoop(head);
    }
    private bool WithTwoPointers(ListNode head){
        var one = head;
        var two = head;
        while(two != null && two.next != null){
            one = one.next;
            two = two.next.next;
            if(one == two) return true;
        }

        return false;
    }

    private bool WithSet(ListNode head){
        if (head == null) return false;
        var set = new HashSet<ListNode>();

        while(head.next != null){
            if(set.Contains(head)) return true;
            set.Add(head);
            head = head.next;
        }
        return false;
    }

    private bool FixedLoop(ListNode head){
        if (head == null) return false;
        var index = 0;
        while(head.next != null){
            if (index > 10000) return true;
            head = head.next;
            index++;            
        }
        return false;
    }
}