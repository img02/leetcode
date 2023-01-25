# Valid Parentheses
## Easy
### https://leetcode.com/problems/valid-parentheses/
#### O(n)

Use an int to count the bracket difference.

Open brackets == -1  
Closed brackets == 1  

If the count is ever more than 0, there are more closed brackets than open -- invalid string


Use a stack - LIFO, for storing open bracket order

Either use a bunch of 'if's, a switch statement, or create a map to match the kvps using open brackets as keys, closed as values.