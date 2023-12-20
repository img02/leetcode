# Longest Substring Without Repeating Characters
## Medium
### https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
#### O(n)

Use a queue  

enqueue each char while !queue.Contains(char)  

once a duplicate char is found, dequeue until substring is clear of the dupe char,  

beginning a new substring...  