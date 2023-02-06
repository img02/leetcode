# Climbing Stairs
## Easy
### https://leetcode.com/problems/climbing-stairs/
#### O(n)

Use memoization  

Record the possible combinations at step m, where n > m > 0   

Recursively counting back from n, with (n-1) (n-2)  

Like a tree

![image](https://user-images.githubusercontent.com/70348218/216863596-db20ecea-8c2b-4a34-af5a-1e7c56ab1f4e.png)





Or using a loop:  
```
Step 0 = 0 steps   
Step 1 =  0 + 1 step    
Step 2 = [ (Step 0) + 2 steps ] + [ (Step 1) + 1 step ].  
Step 3 = [ (Step 1) + 2 steps ] + [ (Step 2) + 1 step ].
...   
Step n = possible combos of (Step n-1) + (Step n-2)
```
Each step has the possible combinations of:  
	the previous steps combinations (+ 1 step to reach curr step),  
	the previous-previous steps combinations + (2 steps to reach curr step)

