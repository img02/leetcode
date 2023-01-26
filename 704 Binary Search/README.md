# Binary Search
## Easy
### https://leetcode.com/problems/binary-search/
#### O(log n)



Set upper and lower indexes  

While lower < upper

Get middle index  

If middle is smaller than target, set lower index to middle  
If middle is larger than target, set upper index to middle  
repeat  

You can use a middle index variable, defined outside of the loop,  
but this requires a repeat check for if (arr[mid] == target), 
because the target can either be met during the loop,  
or if it's the part of the last index searched before the loop condition is met - lower < upper  
in which case, you'll need to check the newly updated index before returning -1.  
Or for the edge case where the array lenght is 1.  


---

When calculating middle index, the middle index can either be skewed to the left or to the right.  

	[... 3, 4, 5, 6, 7, 8...]	
	     ^     ^  ^     ^
	    low    mid?   upper  
		
middle = (upper + lower) / 2  		|- left side 
middle = (upper + lower + 1) / 2	|- right side

Depending on which you go with, you need to adjust your logic for changing upper/lower indexes  

When changing boundaries, you can do so inclusive or exclusive of the middle index  
This is important when there are two indexes left.  
	
	mid		(target = 6)
	 V
	[4, 6]		if skewing left for middle and adjusting lower to be = middle,
	 ^  ^		when the target is greater than the mid index value, 
	lo  hi		this will cause an infinite loop. lower = mid, upper = mid - 1
	

	
	mid		(target = 6)
	 V
	[4, 6]		But if upper inclusive, lower exclusive
	 ^  ^		lower = mid + 1, upper = mid
	lo  hi		lower == upper, breaking loop
				lower = index of 6, the target
				
				Which means no need to var mid to exist outside of the loop  				
				



