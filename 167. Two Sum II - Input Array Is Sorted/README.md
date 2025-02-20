# Two Sum II - Input Array Is Sorted
## Medium
### https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/
#### O(n)


two pointers  

- since arr is sorted,
- while l<r
- if total == target, return l,r (+1)
- if total > target, too big, decrement r
- else increment l




OR  



same as two sum  

- use a dictionary to track compliments
- loop through array
- if current number exists as a compliment to another
	- return current index and compliment index
- otherwise, add [(target - current), index] as a compliment to dict.

