# Reverse Linked List
## Easy
### https://leetcode.com/problems/reverse-linked-list/

```
 (head)                          (Tail)
  node1     node2       node3     etc
 ------     ------     ------     
 |next| --> |next| --> |next| --> ...  --> null
 ------     ------     ------     
 ```
 
The last node pointer in a linked list will be null because there are no more nodes.

> prev = null;

for each node, you need to point it's next node to the previous node.
> node.next = prev;

But first! You need to maintain a reference to the original next node so that you can go to it next and reverse it as well.

> next = node.next;

Then once you've pointed the node.next to the previous node, you have to change the previous node to the current node
so that in the next iteration you can once again point the node.next to the previous node before it.

```
next = node.next

// now that we have reference to the next node in the list
// make the nodes next node to the previous node
node.next = prev;
prev = node;

//now we can repeat with the original next node in the list
node = next

repeat... until node is null, then return previous node as the new head of the reversed list.
```

```
         (head)                          (Tail)
1.       >node1<     node2       node3     etc
         ------     ------     ------     
null     |next| --> |next| --> |next| --> ...  --> null
         ------     ------     ------     
 ^          >>>>>>>>^        
prev        ^ 
            next


2.       node1     >node2<       node3     etc
        ------     ------     ------     
null <--|next|     |next| --> |next| --> ...  --> null
        ------     ------     ------     
           ^          >>>>>>>>>^        
          prev        ^ 
                      next
                      

3.       node1     node2      >node3<     etc
        ------     ------     ------     
null <--|next| <-- |next|     |next| --> ...  --> null
        ------     ------     ------     
                      ^          >>>>>>>>>^        
                     prev        ^ 
                                 next
                                 


4.       node1     node2       node3    >etc<
        ------     ------     ------     
null <--|next| <-- |next| <-- |next|     ...  --> null
        ------     ------     ------     
                                ^          >>>>>>>>>^        
                               prev        ^ 
                                           next
                                           
                                           
        (tail)                          (head) - returned as head of reversed list
5.       node1     node2       node3    >etc<
        ------     ------     ------     
null <--|next| <-- |next| <-- |next| <-- ...     null
        ------     ------     ------     
``` 
 
