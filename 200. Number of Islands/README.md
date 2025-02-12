# Number of Islands
## Medium
### https://leetcode.com/problems/number-of-islands/description/
#### O(m*n)

```
Example 1:

Input: grid = [
  ["1","1","1","1","0"],
  ["1","1","0","1","0"],
  ["1","1","0","0","0"],
  ["0","0","0","0","0"]
]
Output: 1

Example 2:

Input: grid = [
  ["1","1","0","0","0"],
  ["1","1","0","0","0"],
  ["0","0","1","0","0"],
  ["0","0","0","1","1"]
]
Output: 3
```


keep a cache of visited (row,col) -- or can just change value to '0' once visited

keep a count of islands

nested for loop - for rows - for columns

if the value is '1' -- increase island count

then initiate search around that island

BFS/DFS (same method, iteratively, but using queue or stack)

- add current (r,c) to queue/stack.
- while not empty
	- dequeue / pop
	- check surrounding directions (left,right,top,bottom)
		- use a direction array of tuples [(1,0),(-1,0),(0,1),(0,-1)]
		- foreach direction
			- check constrains 
				- row - row direction > 0 and < max row length
				- col - col direction > 0 and < max col length
			- if grid at these locations contains '1'
				- enqueue / push (r,c)
				- add to visited
- rinse, repeat
- return island count


DFS Recursive

- check constraints
	- if out of bounds return
	- if '0' return
- if '1' change to '0' to mark as visited
- recursive calls 
	- go all the way left
	- go all the way right
	- go all the way up
	- go all the way down
	- etc
