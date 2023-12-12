# 347. Top K Frequent Elements
## Medium
### https://leetcode.com/problems/top-k-frequent-elements/description/
#### O(n)


Store a count of each number in a dictionary.  

Use a PriorityQueue<number, frequency> to store the highest frequency numbers, dequeueing when count > K  


--------  

Use an array of Stack<int>[nums.Length+1]. -- 1-indexed to simplify   

Prepopulate with empty stacks.  

Iterate over kvps and push to appropriate key (number) index stack.  

Iterate over stack array in reverse, popping any numbers off and storing in results until K is satisfied.  





