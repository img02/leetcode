# Valid Anagram
## Easy
### https://leetcode.com/problems/valid-anagram

https://www.rapidtables.com/code/text/ascii-table.html

Make an array of int size 26. (26 letters in alphabet, duh) 

this will mean a = 0, z = 25

For each character in the first string, subtract the value of char 'a' or 91 - the ASCII value
and increase the the count at that index in the alphabet array.

For each char in the second string, do the same thing but decrease the count at that index
in the alphabet array.

Then check each value in the array, if any are not equal to 0, immediately return false.


OR

use a standard library function to sort the strings alphabetically and compare using equality operator.


OR

Use a dictionary / map to track count <char, int>
+1 for first string,
-1 for second string,
check if each kvp value is 0