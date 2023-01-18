Conventionally starting from the left of the string,
1s have more 'weight' and need to be on the right side, 
therefore their count should be taken.

As we iterate over the chars of the string, 
we are increasing the subsection we are working on / sorting

So if the new char (on the far right) is a 1 - we increase 1 count and move on

If the new char is a 0, because 1s must be to the right and 0s to the left for monotone increasing,
we need to increase (potential) minimum required flips count,
and then compare the new min_flips to the ones_count, and reassign it to the smaller value

This is because we need to determine if there are less steps 
in flipping all the current 1s (turning it all to zeroes)
or in the current min_flips (which initially consists of 0s, but depending on string length will also eventually become a mix of flips that include 1s)

Example:
```
 1  0  1  0  0  1  1  0  1     | Ones | MinFlips    (new subsections are shown by pipes around nums)
___
|1| 0  1  0  0  1  1  0  1     | 1       | 0
_____
|1  0| 1  0  0  1  1  0  1     | 1       | 1      (they are equal so min flips remains 1)
_________
|1  0  1|  0  0  1  1  0  1    | 2       | 1
____________
|1  0  1  0| 0  1  1  0  1     | 2       | 2      (min_flips increase to 2, then compared to ones_count and assigned w/e is smaller)
_______________
|1  0  1  0  0| 1  1  0  1     | 2       | 2      (min_flips = 3, compare w/ ones_count, reassign to ones_count value)
                                                            this is because it's determined to be less steps to flip 
__________________ 			                                     all 1s than all 0s in current subsection.
|1  0  1  0  0  1| 1  0  1     | 3       | 2
_____________________
|1  0  1  0  0  1  1| 0  1     | 4       | 2
________________________
|1  0  1  0  0  1  1  0| 1     | 4       | 3      (min_flips = 3, less than ones_count, remain as 3)
                                                            because less steps to flip all 0s than all 1s in this subsection

________________________ 
|1  0  1  0  0  1  1  0 1|     | 5       | 3

min_flips is 3
by incrementally determining the minimum flips for each subsection as we traverse the string
we are able to find the total min flips for the whole string.
_     _              _
1  0  1  0  0  1  1  0 1
    to
0  0  0  0  0  1  1  1 1
```

This process can be done in reverse from the right side.
Instead count 0s and increase potential minimum flip on 1s.



   
