# Two Sum
## Easy
### https://leetcode.com/problems/two-sum
#### O(n)


Using a map, for each value - subtract it from target. The result is the compliment value required.
Before adding to map/dictionary, check if the compliment value exists as a key, if so you've found the two numbers to sum up to target.
Otherwise, add the value as a key with it's index and the value.

