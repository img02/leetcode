# Longest Repeating Character Replacement
## Medium
### https://leetcode.com/problems/longest-repeating-character-replacement/description/
#### O(n)

sliding window  

use map to track letter counts  

track max repeat char count (the main letter)   

if a substring has (length of substring - maxRepeatChar) > k  

too many char to replace, move left pointer.  

otherwise calc longest  

always move right pointer ++  