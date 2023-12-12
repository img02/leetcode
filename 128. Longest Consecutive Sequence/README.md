# Longest Consecutive Sequence
## Medium
### https://leetcode.com/problems/longest-consecutive-sequence/
#### O(n)

Use HashSet to remove dupes, iterate over it.  

If the Set contains the num-1, current number is not the start of a sequence, continue  

Otherwise it is the start of a sequence, current length of seq is 0, iterate and check if num + length exists, increase length.  

If length > current longest, update.  

Finally return longest seq count.