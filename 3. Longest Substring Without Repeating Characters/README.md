# Longest Substring Without Repeating Characters
## Medium
### https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
#### O(n)

Use a queue  

enqueue each char while !queue.Contains(char)  

once a duplicate char is found, dequeue until substring is clear of the dupe char,  

beginning a new substring...  



Use a map

key, value = char, index  

use left, right pointers  

if map has char,  
-	update left pointer to be 
	- the index of that char + 1
	- or remain the same
	- whichever is greatest
-	update longest value
	- right - left + 1;
	- ex: 1,5 - 5-1 = 4, +1 because inclusive.
	