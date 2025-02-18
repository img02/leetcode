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


--------

Use bucket sort

create int array of array of num length. new Array(nums.length + 1), List<int>[nums.Length+1]  

prefill with empty arrays / lists.  

go through dictionary / map and use the frequency count (value) as the index,  

add the key(number) to the subarray.  

then iterator through the 'bucket' array in reverse,  

adding subarray values until k == 0; return





